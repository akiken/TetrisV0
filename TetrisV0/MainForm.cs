using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisV0.Control;
using TetrisV0.Framework.Core;
using TetrisV0.Model;
using TetrisV0.View;

namespace TetrisV0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TetrisInstance.model.configure();
            TetrisInstance.view.configure(this);
            TetrisInstance.control.configure();

            MVC.Instance().configure(1, new MainGameControl(), new MainGameModel(), new MainGameView(this));
            MVC.Instance().callAction(1, MainGameControl.ID_START);
        }

        public PictureBox getMainFieldPictureBox()
        {
            return picturebox_mainfield;
        }

        delegate void RefreshCallback(PictureBox target);
        private void Refresh(PictureBox target)
        {
            if (target.InvokeRequired)
            {
                RefreshCallback d = new RefreshCallback(Refresh);
                try
                {
                    this.Invoke(d, new object[] { target });
                }
                catch
                {
                }
            }
            else
            {
                target.Refresh();
            }
        }

        public void refreshMainFieldPictureBox()
        {
            Refresh(picturebox_mainfield);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button_debug1_Click(object sender, EventArgs e)
        {
            MVC.Instance().callAction(1, MainGameControl.ID_STOP).ExecuteResult();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TetrisInstance.control.timeControl.stop();
        }
    }
}
