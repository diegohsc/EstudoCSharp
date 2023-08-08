using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    class conversaoDados
    {

        static void Main(string[] args)
        {


            // boxing (converte um tipo para Object)
            Console.WriteLine("----- Boxing");

            int percentual = 10;
          
            object objPercentual = percentual;
            Console.WriteLine($"percentual: {percentual} - {percentual.GetType()}");
            Console.WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");
      
            decimal salario = 12500.50M;
            object objSalario = salario;
            Console.WriteLine($"salario: {salario}- { salario.GetType()}");
            Console.WriteLine($"objSalario:  { objSalario}-  { objSalario. GetType()}");

        }
    }
}
