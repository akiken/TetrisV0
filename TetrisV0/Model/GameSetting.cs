using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Model
{
    class GameSetting
    {
        int width = 9;     // マス幅
        int height = 15;   // マス高さ
        int size = 50;     // マスサイズ

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }
    }
}
