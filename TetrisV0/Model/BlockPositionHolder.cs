using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisV0.Model
{
    class BlockPositionHolder
    {
        /**
         * @brief   ブロックホルダ
         * @note    固定済みブロックは正、移動中ブロックは負、ブロックなしは0とする
         */
        public int[] blocks;
        public int[] nextBlock;


        public bool bGameOver;

        public BlockPositionHolder()
        {
            int width = TetrisInstance.model.setting.Width;
            int height = TetrisInstance.model.setting.Height;

            blocks = new int[width * height];
            blocks[0 + 5 * width] = -1;
            blocks[1 + 5 * width] = -1;

            nextBlock = new int[width * 4];
            bGameOver = false;
        }

        public void notifyUpdate()
        {
            int width = TetrisInstance.model.setting.Width;
            int height = TetrisInstance.model.setting.Height;
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
            int width = TetrisInstance.model.setting.Width;
            int height = TetrisInstance.model.setting.Height;
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
                foreach(int i in moveBlockList)
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
