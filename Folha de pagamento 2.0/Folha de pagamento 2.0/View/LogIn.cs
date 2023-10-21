using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_pagamento_2._0
{
    public partial class LogIn : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TOMBINEE;Initial Catalog=pim;Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();

            tb_usuario.Select();
            btn_criar.Hide();
            tb_confirmar.Hide();
            lb_confirmar.Hide();
        }
        int verificacao()
        {
            
            if(tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Digite um usuário e senha!");
                tb_usuario.Select();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            int teste = verificacao();
            if (teste == 1)
            {
                conn.Open();
                string busuario = "SELECT * FROM usuario where usuario = '" + tb_usuario.Text + "' AND senha = '" + tb_senha.Text + "'";

                SqlDataAdapter dp = new SqlDataAdapter(busuario, conn);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Principal principal = new Principal();
                    this.Hide();
                    principal.Show();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Usuário ou senha invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_usuario.Clear();
                    tb_senha.Clear();
                    tb_usuario.Select();
                }
            }
        }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            btn_criar.Show();
            btn_entrar.Hide();
            lnk_criarUser.Hide();
			tb_confirmar.Show();
			lb_confirmar.Show();
		}

		private void btn_criar_Click(object sender, EventArgs e)
		{
			string strsql = "insert into usuario (usuario, senha) values (@USUARIO, @SENHA)";
			SqlCommand cmd = new SqlCommand(strsql, conn);

			cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = tb_usuario.Text;
			cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = tb_senha.Text;

			try
			{
				if(tb_senha.Text == tb_confirmar.Text)
                {
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso");
					conn.Close();
					btn_criar.Hide();
					tb_confirmar.Hide();
					lb_confirmar.Hide();
                    btn_entrar.Show();
                    lnk_criarUser.Show();
                    tb_usuario.Clear();
                    tb_senha.Clear();   
				}
                else
                {
                    MessageBox.Show("Senhas incompativeis!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_confirmar.Select();
                }
                
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
