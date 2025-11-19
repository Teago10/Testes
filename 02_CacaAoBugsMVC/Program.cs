using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAoBugsMVC.Controller;
using _02_CacaAoBugsMVC.Model;

namespace _02_CacaAoBugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlunoController controller = new AlunoController();
            var validacao = controller.GetValidaService();
            Console.Clear();
            Console.WriteLine("=== Sistema de Notas - Caça ao Bug MVC ===");
            string nome;
            while (true)
            {
                while (true)
                {

                    while (true)
                    {
                        Console.Write("Informe o nome do Aluno:");
                        nome = Console.ReadLine();

                        if (validacao.ValidaNome(nome, out string msgErro)) break;

                        Console.WriteLine($"Erro:\n{msgErro}\n");
                    }

                    double nota1 = Program.LerNota("1°", validacao);
                    double nota2 = Program.LerNota("2°", validacao);
                    double nota3 = Program.LerNota("3°", validacao);

                    //-----------Criar o objeto Aluno e enviar para a controller -----------//

                    var aluno = new Aluno()
                    {
                        Nome = nome,
                        Nota1 = nota1,
                        Nota2 = nota2,
                        Nota3 = nota3
                    };

                    if (controller.AdicionaAluno(aluno, out string msgErroAdd))
                    {
                        Console.WriteLine($"\nMédia: {aluno.Media}");
                        Console.WriteLine($"\nSituação: {aluno.Situacao}");
                    }
                    else
                    {
                        Console.WriteLine($"Erro: {msgErroAdd}");
                    }
                    //-----------------------------------------------------------------------//

                    Console.WriteLine("Deseja cadastrar outro Aluno? (S/N) ");
                    if (Console.ReadLine().ToUpper() != "S") break;
                }

                //-------------- Estatisticas de Aprovação ----------------//

                Console.WriteLine($"Taxa de Aprovação: {controller.ObterTaxaAprovacao():f2}%");


                Console.WriteLine("Deseja reiniciar o sistema? (S/N)");
                if (Console.ReadLine().ToUpper() != "S") break;
            }
        }

        public static double LerNota(string nota, ValidaService validacao)
        {
            while (true)
            {
                Console.Write($"Informe a {nota} Nota:");
                string entrada = Console.ReadLine();
                //return double.Parse(entrada);
                if (validacao.ValidaNota(entrada, out double valorNota)) return valorNota;

                Console.WriteLine("Nota Inválida! Digite um número entra 0 e 10.");
            }
        }

    }
}