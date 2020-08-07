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
    public partial class Quest9 : Form
    {
        public Quest9()
        {
            InitializeComponent();
        }

        private void btnIllegal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnLegitimate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta certa!");
            Quest10 a = new Quest10();
            a.Show();
            Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }
    }
}
