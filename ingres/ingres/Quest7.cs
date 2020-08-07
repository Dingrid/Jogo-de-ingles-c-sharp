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
    public partial class Quest7 : Form
    {
        public Quest7()
        {
            InitializeComponent();
        }

        private void btnBake_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest8 a = new Quest8();
            a.Show();
            Hide();
        }
    }
}
