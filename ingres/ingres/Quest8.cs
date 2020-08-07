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
    public partial class Quest8 : Form
    {
        public Quest8()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest9 a = new Quest9();
            a.Show();
            Hide();
        }
    }
}
