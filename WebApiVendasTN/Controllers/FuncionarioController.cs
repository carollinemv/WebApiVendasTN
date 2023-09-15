using Microsoft.AspNetCore.Mvc;
using WebApiVendasTN.Dominio;

namespace WebApiVendasTN.Controllers
{
    public class FuncionarioController : ControllerBase
        
    {
        [HttpPost("Adicionar Funcionario")]
        public ActionResult<Funcionario>AdicionarFuncionario(Funcionario funcionarioTela)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = funcionarioTela.Nome;
            funcionario.Cpf=funcionarioTela.Cpf;
            funcionario.Cargo=funcionarioTela.Cargo;
            funcionario.Salario=funcionarioTela.Salario;
            funcionario.DataAdmissao= funcionarioTela.DataAdmissao;
            funcionario.Adicionar();
            return funcionario;
        }
        [HttpPut("Alterar Funcionario")]
        public ActionResult<Funcionario> AlterarFuncionario(Funcionario funcionarioTela)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = funcionarioTela.Nome;
            funcionario.Cpf = funcionarioTela.Cpf;
            funcionario.Cargo = funcionarioTela.Cargo;
            funcionario.Salario = funcionarioTela.Salario;
            funcionario.DataAdmissao = funcionarioTela.DataAdmissao;
            funcionario.Alterar(funcionarioTela.Id);
            return funcionario;
        }
        [HttpDelete("Excluir Funcionario")]
        public ActionResult<Funcionario>ExcluirFuncionario(int idFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Excluir(idFuncionario);
            return funcionario;
        }
        [HttpGet("Pesquisar Por ID Funcionario")]
        public ActionResult<string>PesquisarPorId(int IdFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.PesquisarporID(IdFuncionario);
            return "";
        }
        [HttpGet("Pesquisar Por Nome Funcionario")]
        public ActionResult<string> PesquisarPorNome(string nomeFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.PesquisarPorNome(nomeFuncionario);
            return "";
        }
        [HttpGet("Pesquisar Todos")]
        public ActionResult<string>ListarTodos()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ListarTodos();
            return "";
        }
    }
}
