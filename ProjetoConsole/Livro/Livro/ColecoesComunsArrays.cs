using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class ColecoesComunsArrays
    {
        static void Main(string[] args)
        {
            int[] primeiraArray = new int[100];

            // Declarando uma array e já atribuindo valores
            int[] segundaArray = new int[] { 1, 3, 5, 7, 9 };

            // Forma alternativa de criar array
            int[] terceiraArray = { 1, 2, 3, 4, 5, 6 };

            // Declarando uma array multi-demensional
            int[,] arrayMultiDimensional = new int[2, 3];

            // Declarando uma array multidemensional e atribuindo valores
            int[,] arrayMultiDimensional2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine($"Posição zero do segundo array {segundaArray[0]} ");


        }
    }
}
