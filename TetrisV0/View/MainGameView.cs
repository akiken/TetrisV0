using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisV0.Framework;
using TetrisV0.Model;

namespace TetrisV0.View
{
    class MainGameView : ViewBase
    {
        MainForm mainForm;
        Graphics g;

        public MainGameView(MainForm form)
        {
            mainForm = form;
            PictureBox pictureBox = form.getMainFieldPictureBox();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.g = Graphics.FromImage(pictureBox.Image);
        }

        public override void ExecuteResult()
        {
            drawField();
            drawBlocks();
        }

        protected void drawField()
        {
            int width = ((MainGameModel)model).Width;
            int height = ((MainGameModel)model).Height;
            int size = ((MainGameModel)model).SizeOfBlock;

            g.FillRectangle(Brushes.White, 0, 0, width * size, height * size);
            for (int x = 0; x <= width; x++)
            {
                g.DrawLine(Pens.Black, x * size, 0, x * size, height * size);
            }

            for (int y = 0; y <= height; y++)
            {
                g.DrawLine(Pens.Black, 0, y * size, width * size, y * size);
            }

            mainForm.refreshMainFieldPictureBox();
        }

        protected void drawBlocks()
        {
            int width = ((MainGameModel)model).Width;
            int height = ((MainGameModel)model).Height;
            int size = ((MainGameModel)model).SizeOfBlock;

            int[] blocks = ((MainGameModel)model).blocks;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (blocks[x + y * width] != 0)
                    {
                        g.FillRectangle(Brushes.Blue, x * size, y * size, size, size);
                    }
                }
            }

            mainForm.refreshMainFieldPictureBox();
        }
    }
}
