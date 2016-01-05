﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisV0.Control;
using TetrisV0.Model;
using TetrisV0.View;

namespace TetrisV0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TetrisInstance.model = new TetrisModel();
            TetrisInstance.view = new TetrisView(picturebox_mainfield);
            TetrisInstance.control = new TetrisControl();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button_debug1_Click(object sender, EventArgs e)
        {
            TetrisInstance.view.field.drawField();
        }


    }
}
