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
    public partial class Quest13 : Form
    {
        public Quest13()
        {
            InitializeComponent();
        }

        private void btnEscorregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnPisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest14 a = new Quest14();
            a.Show();
            Hide();
        }

        private void btnMachucar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }
    }
}
