using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class listas
    {
        static void Main(string[] args)
        {
            List<string> funcionarios = new List<string>();
            funcionarios.Add("funcionario 1");
            funcionarios.Add("funcionario 2");
            funcionarios.Add("funcionario 2");

            foreach (string item in funcionarios)
            {
                Console.WriteLine($"funcionario {item}");
            }

            funcionarios.RemoveAt(0);


            foreach (string item in funcionarios)
            {
                Console.WriteLine($"funcionario: {item}");
            }





        }




        public class ListaGenerica<T>
        {
            public void Adicionar(T input)
            { }
        }




        private class ExampleClass { }
            static void Tesla()
            {
                //lista do tipo inteiro.
                ListaGenerica<int> lista1 = new ListaGenerica<int>();
                lista1.Adicionar(1);
                lista1.Adicionar(3);

                ListaGenerica<string> lista2 = new ListaGenerica<string>();
                lista2.Adicionar("teste");
                lista2.Adicionar("teste");
            }

        
           
    }
}
