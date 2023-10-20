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
    public class ClassFuncionariosController
    {
        SqlConnection conn = null;
        private string sql = @"Data Source=TOMBINEE;Initial Catalog=funcionarios;Integrated Security=True";
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

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
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
            strsql = "update funcionario set (CPF, Nome, Endereço, Bairro, CEP, Telefone, UF, Cidade) values (@CPF, @Nome, @Endereço, @Bairro, @CEP, @Telefone, @UF, @Cidade)";
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

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
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
                MessageBox.Show("Registro excluido com sucesso!");
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
