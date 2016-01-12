using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Control
{
    class TimeControl
    {
        private TimeControl()
        {
            t = new Stopwatch();
            t.Start();

            System.Threading.TimerCallback timerDelegate = new System.Threading.TimerCallback(tkTime);
            timerItem = new System.Threading.Timer(timerDelegate, null, 100, 100);
            sysCount = 0;
        }

        static public TimeControl GetInstance()
        {
            return instance;
        }

        public void stop()
        {
            sysCount = -1;
            t.Stop();
            timerItem.Change(0, System.Threading.Timeout.Infinite);
        }

        public void tkTime(object StateObj)
        {
            if (sysCount >= 0)
            {
                func100ms();
                func1000ms();

                sysCount++;
                if (sysCount >= 10)
                {
                    sysCount = 0;
                }
            }
        }

        private void func100ms()
        {
            //TetrisInstance.view.field.notifyUpdateGameField();
        }

        private void func500ms()
        {
            switch (sysCount % 5)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        private void func1000ms()
        {
            switch (sysCount % 10)
            {
                case 0:
                    TetrisInstance.model.blockPosition.notifyUpdate();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 9:
                    break;
                default:
                    break;
            }
        }

        Stopwatch t;       // ゲーム起動からの時間計測
        System.Threading.Timer timerItem;   // タスク実行タイマ
        int sysCount;

        static TimeControl instance = new TimeControl();
    }
}
