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
    public partial class Quest5 : Form
    {
        public Quest5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa! Parabéns! You win!");
            Menu a = new Menu();
            a.Show();
            Hide();
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
            MessageBox.Show("Resposta errada!");
            Menu a = new Menu();
            a.Show();
            Hide();
        }
    }
}
