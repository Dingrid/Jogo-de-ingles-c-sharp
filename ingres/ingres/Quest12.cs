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
    public partial class Quest12 : Form
    {
        public Quest12()
        {
            InitializeComponent();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnKnow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnWell_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Quest13 a = new Quest13();
            a.Show();
            Hide();
        }
    }
}
