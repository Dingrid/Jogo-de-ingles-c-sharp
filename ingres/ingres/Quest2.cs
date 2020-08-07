using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Quest2 : Form
    {
        public Quest2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada!");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest3 a = new Quest3();
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
