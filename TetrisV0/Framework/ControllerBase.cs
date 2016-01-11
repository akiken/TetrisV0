using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Framework.Core;

namespace TetrisV0.Framework
{
    class ControllerBase
    {
        protected ViewBase view;
        protected ModelBase model;

        protected class ActionRouting
        {
            public delegate ActionResult daction(ArgBag arg);
            public int actionID;
            public daction action;

            public ActionRouting(int actionID, daction action)
            {
                this.actionID = actionID;
                this.action = action;
            }
        }

        protected List<ActionRouting> actionRoutingList;

        public ControllerBase()
        {
            actionRoutingList = new List<ActionRouting>();
            actionRoutingList.Add(new ActionRouting(-1, DefaultAction));
        }

        public void configure(ViewBase view, ModelBase model)
        {
            this.view = view;
            this.model = model;
        }

        public ActionResult callAction(int ID, ArgBag arg)
        {
            ActionRouting target = null;
            foreach (ActionRouting action in actionRoutingList)
            {
                if(ID == action.actionID)
                {
                    target = action;
                }
            }

            if(null != target)
            {
                return target.action(arg);
            }
            else
            {
                return null;
            }
        }

        public ViewBase DefaultAction(ArgBag arg)
        {
            return View();
        }

        public ViewBase View()
        {
            return view;
        }
    }
}
