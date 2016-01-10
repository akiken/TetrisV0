using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Model;
using TetrisV0.View;

namespace TetrisV0.Control
{
    class TetrisControl
    {
        public TetrisControl()
        {
            timeControl = TimeControl.GetInstance();
        }

        public void configure()
        {

        }

        public TimeControl timeControl;
    }
}
