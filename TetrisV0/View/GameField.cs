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
        public GameField(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.g = Graphics.FromImage(this.pictureBox.Image);

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

            pictureBox.Refresh();
        }

        PictureBox pictureBox;
        Graphics g;

        int width;
        int height;
        int size;
    }
}
