﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Quest1 : Form
    {
        public Quest1()
        {
            InitializeComponent();
        }

        private void Quest1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest2 a = new Quest2();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada!");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada!");
            Menu a = new Menu();
            a.Show();
            Hide();
        }
    }
}
