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
    public partial class Quest15 : Form
    {
        public Quest15()
        {
            InitializeComponent();
        }

        private void btnBater_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnBaderna_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resposta errada");
            Menu a = new Menu();
            a.Show();
            Hide();
        }

        private void btnCama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Awesome! Você venceu o jogo, seu Inglês é impressionante!");
            Menu a = new Menu();
            a.Show();
            Hide();
        }
    }
}
