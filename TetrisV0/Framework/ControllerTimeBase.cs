using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Control;
using TetrisV0.Framework.Core;

namespace TetrisV0.Framework
{
    class ControllerTimeBase : ControllerBase
    {
        protected System.Threading.Timer threadTimer;   // タスク実行タイマ
        int dueTime;
        int period;
        bool bStarted;

        public const int ID_START = 1;
        public const int ID_STOP  = 2;

        public ControllerTimeBase(int dueTime, int period)
        {
            this.dueTime = dueTime;
            this.period = period;
            this.bStarted = false;

            addActionRoute(new ActionRouting(ID_START, start));
            addActionRoute(new ActionRouting(ID_STOP, stop));
        }

        virtual public void main(object StateObj)
        {
            // 周期的に実行したい処理を記述
        }

        public ActionResult start(ArgBag arg)
        {
            if (!bStarted)
            {
                System.Threading.TimerCallback timerDelegate = new System.Threading.TimerCallback(main);
                threadTimer = new System.Threading.Timer(timerDelegate, null, dueTime, period);
                bStarted = true;
            }
            return View();
        }

        public ActionResult stop(ArgBag arg)
        {
            if (bStarted)
            {
                threadTimer.Dispose();
            }
            return View();
        }
    }
}
