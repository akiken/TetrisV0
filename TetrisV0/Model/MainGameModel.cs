using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisV0.Framework;

namespace TetrisV0.Model
{
    class MainGameModel : ModelBase
    {
        /**
         * @brief   ブロックホルダ
         * @note    固定済みブロックは正、移動中ブロックは負、ブロックなしは0とする
         */
        public int[] blocks;
        public int[] nextBlock;

        public int Width;
        public int Height;
        public int SizeOfBlock;

        public bool bGameOver;

        public MainGameModel()
        {
            Width = 9;
            Height = 15;
            SizeOfBlock = 30;

            blocks = new int[Width * Height];
            blocks[0 + 5 * Width] = -1;
            blocks[1 + 5 * Width] = -1;

            nextBlock = new int[Width * 4];
            bGameOver = false;
        }

        public void notifyUpdate()
        {
            int width = Width;
            int height = Height;
            int size = width * height;

            updateMovingBlocks();

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (blocks[y * width + x] != 0 && nextBlock[y * width + x] != 0)
                    {
                        bGameOver = true;
                        break;
                    }
                }
            }

            if (!bGameOver)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (nextBlock[y * width + x] != 0)
                        {
                            blocks[y * width + x] = nextBlock[y * width + x];
                        }
                    }
                }
            }
        }

        private void updateMovingBlocks()
        {
            int width = Width;
            int height = Height;
            int size = width * height;

            // 移動中ブロックの位置更新
            List<int> moveBlockList = new List<int>();
            bool bEnableMove = true;
            for (int i = 0; i < size; i++)
            {
                if (blocks[i] < 0) // if(移動中ブロックである)
                {
                    moveBlockList.Add(i);
                    if ((i + width) < size)
                    {
                        if (0 == blocks[i + width])
                        {
                        }
                        else
                        {
                            bEnableMove = false;
                        }
                    }
                    else
                    {
                        bEnableMove = false;
                    }
                }
            }

            if (bEnableMove)
            {
                foreach (int i in moveBlockList)
                {
                    blocks[i + width] = blocks[i];
                    blocks[i] = 0;
                }
            }
            else
            {
                foreach (int i in moveBlockList)
                {
                    blocks[i] = -blocks[i];
                }
            }
        }
    }
}
