using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empresa = "Thega - DML";
            string endereco = null;
            string numero = null;
            string Nome = "teste de split";
            Console.WriteLine($"Nome da empresa: {empresa.Trim()}");
            if (empresa.ToUpper().Equals("THEGA", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("OS nomes são iguais.");
            }
            else
            {
                Console.WriteLine("os Nomes são diferentes.");
            }

            string[] blocos = Nome.Split(' ');
            int cont = 1;

            foreach (var item in blocos)
            {
                Console.WriteLine($"item {cont++} : {item}");

            }
            if (string.IsNullOrEmpty(endereco) && string.IsNullOrEmpty(numero)) {
                Console.WriteLine("endereço não informado");          
            }

            Console.WriteLine("quantidade de palavras " + blocos.Length);
            Console.WriteLine(empresa.Substring(0, 5));
            Console.WriteLine(empresa.Substring(empresa.IndexOf('D'), 3));
        }
    }
}
