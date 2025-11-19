/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugsMVC
{
    internal class PassagemParametro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Passagem de Parametro por Valor ***");
            // Passa o conteudo da variavel de Origem para a variavel de destino
            // O método de destino não altera o valor da variavel de Origem
            double valor = 10;
            if(PassagemParametroValor(valor));
                Console.WriteLine($"Valor do método Main --> PassagemParametroValor {valor}");

            Console.WriteLine("*** Passagem de Parametro por Referencia REF ***");
            //Passa o endereço de memória da variável de Origem para a variável de Destino 
            //0 variável de origem pode estar inicializada 
            //O método de destino pode alterar o valor da variável do método de origem

            double valor1 = 10;
            if (PassagemParametroReferenciaRef(ref valor1))
            {
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaRef {valor1}");
            }

            Console.WriteLine("*** Passagem de Parametro por Referencia OUT ***");

            //Passa o endereco de memória da variável de Origem para a variável de Destino, 
            //0 variável de oriaem não pode estar inicializada 
            //O método de destino deve inicializar a variavel do método de origem 
            //0 método de destino pode alterar o valor da variável do método de origem

            double valor2 = 10;
            if(PassagemParametroReferenciaOut(out valor2))
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaOut {valor2}");

            Console.WriteLine("*** Passagem de Parametro por Referencia IN ***");

            //Passa o endereço de memória da variável de Origem para a variável de Destino. 
            //O variável de origem deve estar inicializada 
            //O método de destino não deve alterar o valor da variável do método de origem

            double valor3 = 100;
            if (PassagemParametroReferenciaIN(in valor3))
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaIN {valor3}");

        }

        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"Valor do método PassagemParametroValor {valor}");

            return true;
        }
        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaRef {valor1}");
            return true;
        }
        public static bool PassagemParametroReferenciaOut(out double valor2)
        {
            valor2 = 10;
            valor2 = valor2 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaOut {valor2}");
            return true;
        }
        public static bool PassagemParametroReferenciaIN(in double valor3) // IN é usado somente para leitura
        {
            Console.WriteLine($"Valor do método PassagemParametroReferenciaIN {valor3}");
            return true;
        }
    }
}
*/