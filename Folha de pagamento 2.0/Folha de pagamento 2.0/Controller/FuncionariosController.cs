using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_pagamento_2._0
{
    public class FuncionariosController
    {
        SqlConnection conn = null;
        private string sql = @"Data Source=TOMBINEE;Initial Catalog=pim;Integrated Security=True";
        private string strsql = string.Empty;
        public void inserir(ClassFuncionarios funcionarios)
        {
            strsql = "insert into funcionario (CPF, Nome, Endereço, Bairro, CEP, Telefone, UF, Cidade) values (@CPF, @Nome, @Endereço, @Bairro, @CEP, @Telefone, @UF, @Cidade)";
            conn = new SqlConnection(sql);

            SqlCommand cmd = new SqlCommand(strsql, conn);

            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionarios.cpf;
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = funcionarios.nome;
            cmd.Parameters.Add("@Endereço", SqlDbType.VarChar).Value = funcionarios.endereco;
            cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = funcionarios.bairro;
            cmd.Parameters.Add("@CEP", SqlDbType.VarChar).Value = funcionarios.cep;
            cmd.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = funcionarios.telefone;
            cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = funcionarios.uf;
            cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = funcionarios.cidade;

            strsql = "insert into dadostrabalhista (Cargo, Salariobase, Horasdetrabalho, Pis, Periculosidade, Dataadmissao, Datademissao, CpfFunc) values (@Cargo, @Salariobase, @Horasdetrabalho, @Pis, @Periculosidade, @Dataadmissao, @Datademissao, @CpfFunc)";
            SqlCommand cmd2 = new SqlCommand(strsql, conn);
            cmd2.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = funcionarios.cargo;
            cmd2.Parameters.Add("@Salariobase", SqlDbType.Decimal).Value = funcionarios.salariobase;
            cmd2.Parameters.Add("@Horasdetrabalho", SqlDbType.Int).Value = funcionarios.horastrabalho;
            cmd2.Parameters.Add("@Insalubridade", SqlDbType.VarChar).Value = funcionarios.insalubridade;
            cmd2.Parameters.Add("@Pis", SqlDbType.Int).Value = funcionarios.pis;
            cmd2.Parameters.Add("@Periculosidade", SqlDbType.Bit).Value = funcionarios.periculosidade;
            cmd2.Parameters.Add("@Dataadmissao", SqlDbType.VarChar).Value = funcionarios.admissao;
            cmd2.Parameters.Add("@Datademissao", SqlDbType.VarChar).Value = funcionarios.demissao;
            cmd2.Parameters.Add("@CpfFunc", SqlDbType.VarChar).Value = funcionarios.cpf;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void editar(ClassFuncionarios funcionarios)
        {
            strsql = @"update funcionario set (CPF, Nome, Endereço, Bairro, CEP, Telefone, UF, Cidade) values (@CPF, @Nome, @Endereço, @Bairro, @CEP, @Telefone, @UF, @Cidade)";
            conn = new SqlConnection(sql);

            SqlCommand cmd = new SqlCommand(strsql, conn);

            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionarios.cpf;
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = funcionarios.nome;
            cmd.Parameters.Add("@Endereço", SqlDbType.VarChar).Value = funcionarios.endereco;
            cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = funcionarios.bairro;
            cmd.Parameters.Add("@CEP", SqlDbType.VarChar).Value = funcionarios.cep;
            cmd.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = funcionarios.telefone;
            cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = funcionarios.uf;
            cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = funcionarios.cidade;

            strsql = "update dadostrabalhista set (Cargo, Salariobase, Horasdetrabalho, Insalubridade, Pis, Periculosidade, Dataadmissao, Datademissao, CpfFunc) values (@Cargo, @Salariobase, @Horasdetrabalho, @Insalubridade, @Pis, @Periculosidade, @Dataadmissao, @Datademissao, @CpfFunc)";
            SqlCommand cmd2 = new SqlCommand(strsql, conn);
            cmd2.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = funcionarios.cargo;
            cmd2.Parameters.Add("@Salariobase", SqlDbType.Decimal).Value = funcionarios.salariobase;
            cmd2.Parameters.Add("@Horasdetrabalho", SqlDbType.Int).Value = funcionarios.horastrabalho;
            cmd2.Parameters.Add("@Insalubridade", SqlDbType.VarChar).Value = funcionarios.insalubridade;
            cmd2.Parameters.Add("@Pis", SqlDbType.Int).Value = funcionarios.pis;
            cmd2.Parameters.Add("@Periculosidade", SqlDbType.Bit).Value = funcionarios.periculosidade;
            cmd2.Parameters.Add("@Dataadmissao", SqlDbType.VarChar).Value = funcionarios.admissao;
            cmd2.Parameters.Add("@Datademissao", SqlDbType.VarChar).Value = funcionarios.demissao;
            cmd2.Parameters.Add("@CpfFunc", SqlDbType.VarChar).Value = funcionarios.cpf;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }


        public void excluir(ClassFuncionarios funcionarios)
        {
            strsql = "delete from funcionario where CPF = @CPF";
            conn = new SqlConnection(sql);

            SqlCommand cmd = new SqlCommand(strsql, conn);

            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionarios.cpf;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso!", "Sucesso");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        
    }

}
