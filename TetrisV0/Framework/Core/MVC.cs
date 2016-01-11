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
        static MVC instance = new MVC();

        private MVC()
        {
            routing = new RouteCollection();

            // sample
            configure(0,
                new Sample.Controllers.SampleController(),
                new Sample.Models.SampleModel(),
                new Sample.Views.SampleView()
            );
        }

        static public MVC Instance()
        {
            return instance;
        }

        public void configure(int controllerID, ControllerBase controller, ModelBase model, ViewBase view)
        {
            routing.Add(new RouteBase(controllerID, controller));
            controller.configure(view, model);
            model.configure();
            view.configure(model);
        }

        public ActionResult callAction(int controllerID, int actionID, ArgBag arg)
        {
            RouteBase target = null;
            foreach (RouteBase route in routing)
            {
                if (route.ID == controllerID)
                {
                    target = route;
                }
            }

            if (null != target)
            {
                return target.controller.callAction(actionID, arg);
            }
            else
            {
                return null;
            }
        }

        public ActionResult callAction(int controllerID, int actionID)
        {
            return callAction(controllerID, actionID, new ArgNull());
        }
    }
}
