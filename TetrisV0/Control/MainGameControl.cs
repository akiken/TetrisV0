using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Framework;
using TetrisV0.Framework.Core;
using TetrisV0.Model;

namespace TetrisV0.Control
{
    class MainGameControl : ControllerTimeBase
    {
        public const int ID_Draw = 1000;
        public const int ID_ReDraw = 1001;
        public const int ID_KeyRight = 1002;

        public MainGameControl() : base(0, 1000)
        {
            addActionRoute(new ActionRouting(ID_Draw, Draw));
            addActionRoute(new ActionRouting(ID_KeyRight, InputKeyRight));
        }

        override public void main(object StateObj)
        {
            // 周期的に実行したい処理を記述

            //MVC.Instance().callAction(1, MainGameControl.ID_Draw).ExecuteResult();
            Draw(new ArgNull()).ExecuteResult();
        }

        public ActionResult Draw(ArgBag arg)
        {
            if (arg.isNotType("ArgNull"))
            {
                throw new Exception("[ERROR] Invalid argument.");
            }

            arg = (ArgNull)arg;

            ((MainGameModel)model).notifyUpdate();

            return View();
        }

        public ActionResult InputKeyRight(ArgBag arg)
        {
            if (arg.isNotType("ArgNull"))
            {
                throw new Exception("[ERROR] Invalid argument.");
            }

            arg = (ArgNull)arg;

            ((MainGameModel)model).notifyUpdate();

            return View();
        }
    }
}
