﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private Scene currentScene;

        public Form1()
        {
            InitializeComponent();
            this.currentScene = new Scene(3);
            this.ScencePictureBox.Image = this.currentScene.GetImage();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
        }
    }
}