using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisV0.Control;
using TetrisV0.Model;

namespace TetrisV0.View
{
    class TetrisView
    {
        public GameField field;

        public TetrisView()
        {
            
        }

        public void configure(MainForm form)
        {
            field = new GameField(form);
        }
    }
}
