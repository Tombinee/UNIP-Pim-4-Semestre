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
    public partial class Funcionarios : Form
    {
        private int funcao;

        public Funcionarios(int tipo)
        {
            InitializeComponent();
            msk_cpf.Select();
            funcao = tipo;
            if(funcao == 1)
            {
                btn_buscar.Enabled = false;
            }

            
        }
        SqlConnection conn = null;
        private string sql = @"Data Source=TOMBINEE;Initial Catalog=funcionarios;Integrated Security=True";
        private string strsql = string.Empty;

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar a operação?","Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                MessageBox.Show("Operação cancelada!");
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            ClassFuncionarios classFuncionarios = new ClassFuncionarios();
            classFuncionarios.cpf = msk_cpf.Text;
            classFuncionarios.nome = tb_nome.Text;
            classFuncionarios.endereco = tb_endereço.Text;
            classFuncionarios.bairro = tb_bairro.Text;
            classFuncionarios.cep = msk_CEP.Text;
            classFuncionarios.telefone = msk_telefone.Text;
            classFuncionarios.uf = tb_uf.Text;
            classFuncionarios.cidade = tb_cidade.Text;
            
            ClassFuncionariosController classFuncionariosController = new ClassFuncionariosController();
            if (funcao == 1)
            {
                classFuncionariosController.inserir(classFuncionarios);
            }else if (funcao == 2)
            {
                classFuncionariosController.editar(classFuncionarios);
            }
            else
            {
                classFuncionariosController.excluir(classFuncionarios);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            strsql = "select * from funcionario where CPF = @CPF";
            conn = new SqlConnection(sql);

            SqlCommand cmd = new SqlCommand(strsql, conn);

            cmd.Parameters.Add(new SqlParameter("@CPF", msk_cpf.Text));
            

            try
            {
                if(msk_cpf.Text == "")
                {
                    throw new Exception("Você precisa digitar um CPF!");
                }
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("CPF Não cadastrado!");
                }
                while (dr.Read())
                {
                    msk_cpf.Text = Convert.ToString(dr["CPF"]);
                    tb_nome.Text = Convert.ToString(dr["Nome"]);
                    tb_endereço.Text = Convert.ToString(dr["Endereço"]);
                    tb_bairro.Text = Convert.ToString(dr["Bairro"]);
                    msk_CEP.Text = Convert.ToString(dr["CEP"]);
                    msk_telefone.Text = Convert.ToString(dr["Telefone"]);
                    tb_uf.Text = Convert.ToString(dr["UF"]);
                    tb_cidade.Text = Convert.ToString(dr["Cidade"]);
                }
                


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            
        }

       
    }
}
