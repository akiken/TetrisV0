using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisV0.View
{
    class GameField
    {
        public GameField(MainForm form)
        {
            mainForm = form;
            PictureBox pictureBox = form.getMainFieldPictureBox();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.g = Graphics.FromImage(pictureBox.Image);

            width = TetrisInstance.model.setting.Width;
            height = TetrisInstance.model.setting.Height;
            size = TetrisInstance.model.setting.Size;
        }

        public void drawField()
        {
            g.FillRectangle(Brushes.White, 0, 0, width * size, height * size);
            for(int x = 0; x <= width; x++)
            {
                g.DrawLine(Pens.Black, x * size, 0, x * size, height * size);
            }

            for (int y = 0; y <= height; y++)
            {
                g.DrawLine(Pens.Black, 0, y * size, width * size, y * size);
            }

            mainForm.refreshMainFieldPictureBox();
        }

        public void drawBlocks()
        {
            int[] blocks = TetrisInstance.model.blockPosition.blocks;

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if (blocks[x + y * width] != 0)
                    {
                        g.FillRectangle(Brushes.Blue, x * size, y * size, size, size);
                    }
                }
            }

            mainForm.refreshMainFieldPictureBox();
        }

        public void notifyUpdateGameField()
        {
            drawField();
            drawBlocks();
        }

        MainForm mainForm;
        Graphics g;

        int width;
        int height;
        int size;
    }
}
