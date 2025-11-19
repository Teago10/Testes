using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAoBugsMVC.Model;

namespace _02_CacaAoBugsMVC.Controller
{
    public class AlunoController
    {
        
        private readonly ValidaService _validaService;
        private readonly AlunoService _alunoService;
        private readonly List<Aluno> alunos;

        public AlunoController()
        {
            _validaService = new ValidaService();
            _alunoService = new AlunoService();
            alunos = new List<Aluno>();
        }

        public bool AdicionaAluno(Aluno aluno, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (!_validaService.ValidaNome(aluno.Nome, out string erroNome))
            {
                mensagemErro = $"Nome inválido {erroNome}";
                return false;
            }

            aluno.Media = _alunoService.CalcularMedia(aluno.Nota1, aluno.Nota2, aluno.Nota3);
            aluno.Situacao = _alunoService.ObterSituacao(aluno.Media);
            alunos.Add(aluno);

            return true;
        }
        // => expressão Lambda
        public IReadOnlyList<Aluno> ObterAlunos() => alunos.AsReadOnly();
        
        public double ObterTaxaAprovacao()
        {
            int totalAlunos = alunos.Count;
            int totalAprovados = alunos.FindAll(a => a.Situacao == "Aprovado").Count;
            return _alunoService.CalcularTaxaAprovacao(totalAlunos, totalAprovados);
        }
        
        public ValidaService GetValidaService() => _validaService;
    }
}
