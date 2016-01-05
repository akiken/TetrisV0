using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Control;
using TetrisV0.Model;
using TetrisV0.View;

namespace TetrisV0
{
    class TetrisInstance
    {
        public static TetrisView view = new TetrisView();
        public static TetrisControl control = new TetrisControl();
        public static TetrisModel model = new TetrisModel();
    }
}
