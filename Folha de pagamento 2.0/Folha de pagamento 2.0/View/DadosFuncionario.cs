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
    public partial class DadosFuncionario : Form
    {
        private int funcao;
        ClassFuncionarios classFuncionarios = new ClassFuncionarios();

        public DadosFuncionario(int tipo)
        {
            InitializeComponent();
            msk_cpf.Select();
            funcao = tipo;
            if(funcao == 1)
            {
                btn_buscar.Enabled = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar a operação?","Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            classFuncionarios.cpf = msk_cpf.Text;
            classFuncionarios.nome = tb_nome.Text;
            classFuncionarios.endereco = tb_endereço.Text;
            classFuncionarios.bairro = tb_bairro.Text;
            classFuncionarios.cep = msk_CEP.Text;
            classFuncionarios.telefone = msk_telefone.Text;
            classFuncionarios.uf = tb_uf.Text;
            classFuncionarios.cidade = tb_cidade.Text;
            classFuncionarios.horastrabalho = Convert.ToInt16(tb_horastrabalho.Text);
            classFuncionarios.pis = tb_pis.Text;
            classFuncionarios.salariobase = Convert.ToDecimal(tb_salariobase.Text);
            classFuncionarios.insalubridade = cbb_insalubridade.ValueMember;
            classFuncionarios.cargo = tb_cargo.Text;
            classFuncionarios.admissao = msk_admissao.Text;
            classFuncionarios.demissao = msk_demissao.Text;

            FuncionariosController classFuncionariosController = new FuncionariosController();
            if (funcao == 1)
            {
                classFuncionariosController.inserir(classFuncionarios);
			}
			else if (funcao == 2)
            {
                classFuncionariosController.editar(classFuncionarios);
			}
            else
            {
                classFuncionariosController.excluir(classFuncionarios);
			}
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string sql = @"Data Source=TOMBINEE;Initial Catalog=pim;Integrated Security=True";
            string strsql = string.Empty;
            strsql = "select f.*,d.* from funcionario as f inner join dadostrabalhista as d on f.CPF = d.CpfFunc";
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
               
                if (dr.HasRows == false)
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
                    tb_horastrabalho.Text = Convert.ToString(dr["Horasdetrabalho"]);
                    tb_pis.Text = Convert.ToString(dr["Pis"]);
                    tb_salariobase.Text = Convert.ToString(dr["Salariobase"]);
                    cbb_insalubridade.ValueMember = Convert.ToString(dr["Insalubridade"]);
                    tb_cargo.Text = Convert.ToString(dr["Cargo"]);
                    msk_admissao.Text = Convert.ToString(dr["Dataadmissao"]);
                    msk_demissao.Text = Convert.ToString(dr["Datademissao"]);
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

        private void cb_periculosidade_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_periculosidade.Checked == true)
            {
                classFuncionarios.periculosidade = 1;
            }
            else if (cb_periculosidade.Checked == false)
            {
                classFuncionarios.periculosidade = 0;
            }
        }
    }
}
