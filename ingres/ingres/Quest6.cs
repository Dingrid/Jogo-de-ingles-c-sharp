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
    public partial class Quest6 : Form
    {
        public Quest6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest7 a = new Quest7();
            a.Show();
            Hide();
        }
    }
}
