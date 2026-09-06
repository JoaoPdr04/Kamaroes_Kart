using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JogoCorrida;
using JogoCorridaWinFormsApp;

namespace JogoCorridaWinFormsApp
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jogo = new Pista("Médio");
            jogo.ShowDialog();
        }

        private void btnDificil_click_Click(object sender, EventArgs e)
        {
            var jogo = new Pista("Difícil");
            jogo.ShowDialog();
        }

        private void btnFacil_click_Click(object sender, EventArgs e)
        {
            var jogo = new Pista("Fácil");
            jogo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
