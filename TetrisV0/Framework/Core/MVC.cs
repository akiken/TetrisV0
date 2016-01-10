using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Framework.Core
{
    class MVC
    {
        RouteCollection routing;

        public MVC()
        {
            routing = new RouteCollection();
        }

        public ActionResult callAction(int controllerID, int actionID)
        {
            RouteBase target = null;
            foreach (RouteBase route in routing)
            {
                if(route.ID == controllerID)
                {
                    target = route;
                }
            }

            if (null != target)
            {
                return target.controller.callAction(actionID);
            }
            else
            {
                return null;
            }
        }
    }
}
