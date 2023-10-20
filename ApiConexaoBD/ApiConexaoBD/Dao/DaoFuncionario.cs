using ApiConexaoBD.Model;
using System.Data;
using System.Data.SqlClient;

namespace ApiConexaoBD.Dao
{
    public class DaoFuncionario
    {
        string conexao = @"Data Source=DESKTOP-M71N3MS;Initial Catalog=DBClientes;Integrated Security=True";

        public List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var funcionario = new Funcionario();
                                funcionario.Nome = reader["nome"].ToString();
                                funcionario.Endereço = reader["endereco"].ToString();
                                funcionario.Email = reader["email"].ToString();
                                funcionario.Senha = reader["senha"].ToString();
                                funcionario.Cpf = reader["cpf"].ToString();
                                funcionarios.Add(funcionario);
                            }
                        }
                    }
                }

            }
            return funcionarios;
        }

        public void InserFuncionario(Funcionario funcionario)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (nome, endereco, email, senha, cpf) VALUES (@Nome, @Endereço, @Email, @Senha, @Cpf)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Endereço", funcionario.Endereço);
                    cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);
                    cmd.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
