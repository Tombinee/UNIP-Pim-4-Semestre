using ApiConexaoBD.Model;
using ApiConexaoBD.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ApiConexaoBD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly FuncionarioRepositorio _funcionarioRepositorio;

        public ValuesController()
        {
            _funcionarioRepositorio = new FuncionarioRepositorio();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Funcionario>> Get()
        {
            return _funcionarioRepositorio.GetFuncionarios;
        }

        [HttpPost]
        public void Post([FromBody] Funcionario funcionario)
        { 
            _funcionarioRepositorio.InserirFuncionario(funcionario);
        }
    }
}