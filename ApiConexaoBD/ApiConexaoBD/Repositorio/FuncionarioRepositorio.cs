using ApiConexaoBD.Dao;
using ApiConexaoBD.Model;

namespace ApiConexaoBD.Repositorio
{
    public class FuncionarioRepositorio
    {
        private readonly DaoFuncionario _daoFuncionario;

        public FuncionarioRepositorio()
        {
            _daoFuncionario = new DaoFuncionario();
        }

        public List<Funcionario> GetFuncionarios
        {
            get
            {
                return _daoFuncionario.GetFuncionarios();
            }
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            _daoFuncionario.InserFuncionario(funcionario);
        }
    }
}
