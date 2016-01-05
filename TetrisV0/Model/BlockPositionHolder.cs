using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Model
{
    class BlockPositionHolder
    {
        public int[,] blocks;

        public BlockPositionHolder()
        {
            int width = TetrisInstance.model.setting.Width;
            int height = TetrisInstance.model.setting.Height;

            blocks = new int[width, height];
            blocks[0, 0] = 1;
            blocks[1, 0] = 1;
        }
    }
}
