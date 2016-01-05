using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Control;
using TetrisV0.View;

namespace TetrisV0.Model
{
    class TetrisModel
    {
        public GameSetting setting;
        public BlockPositionHolder blockPosition;

        public TetrisModel()
        {
            setting = new GameSetting();
        }

        public void configure()
        {
            blockPosition = new BlockPositionHolder();
        }
    }
}
