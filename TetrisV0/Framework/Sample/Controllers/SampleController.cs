using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Framework.Sample.Controllers
{
    class SampleController : ControllerBase
    {
        public enum AID{
            Action1 = 1,
            Action2
        }

        public SampleController()
        {
            actionRoutingList.Add(new ActionRouting((int)AID.Action1, Action1));
            actionRoutingList.Add(new ActionRouting((int)AID.Action2, Action2));
        }

        public ViewBase Action1()
        {
            return View();
        }

        public ViewBase Action2()
        {
            return View();
        }
    }
}
