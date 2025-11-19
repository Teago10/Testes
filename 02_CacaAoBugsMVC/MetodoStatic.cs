/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugsMVC
{
    internal class MetodoStatic
    {
        static void Main(string[] args)
        {
            MetodoStatic obj = new MetodoStatic();
            Console.WriteLine($"Nota do método Estática: {obj.LerNotaInstancia()}");
            Console.WriteLine($"Nota do método Estática: {MetodoStatic.LerNota()}");

        }
        // Método Static pertence a Classe
        public static double LerNota()
        {
            return 0.0;
        }
        // Método Não Static pertence a instância
        public double LerNotaInstancia()
        {
            return 0.0;
        }
    }
}
*/