using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_pagamento_2._0
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DadosFuncionario funcionarios = new DadosFuncionario(1);
            funcionarios.Show();
            
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DadosFuncionario funcionarios = new DadosFuncionario(2);
            funcionarios.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            DadosFuncionario funcionarios = new DadosFuncionario(3);
            funcionarios.Show();
        }

		private void calculadoraDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
