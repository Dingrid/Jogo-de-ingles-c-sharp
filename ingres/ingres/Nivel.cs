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
    public partial class Nivel : Form
    {
        public Nivel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quest1 facil = new Quest1();
            facil.Show();
            Hide();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu inicio = new Menu();
            inicio.Show();
            Hide();
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            Quest6 medio = new Quest6();
            medio.Show();
            Hide();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            Quest11 dificil = new Quest11();
            dificil.Show();
            Hide();
        }
    }
}
