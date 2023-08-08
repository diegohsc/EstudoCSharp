using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class ConversaoDeValoresParse
    {
        static void Main(string[] args)
        {
            try
            {
                // Conversões com PARSE
                Console.WriteLine("----- .Parse");
                Console.WriteLine($"{Int16.Parse("150")}");


                // retorna -150, os parênteses representam o   valor negativo
                Console.WriteLine($"{Int16.Parse("(150)", NumberStyles.AllowParentheses)}");
                // retorna 50000 mesmo com o ponto de milhar
                Console.WriteLine($"{int.Parse("50.000", NumberStyles.AllowThousands)}");

                // retorna 50000 mesmo com o símbolo monetário
                Console.WriteLine($"Cultura  atual:  {CultureInfo.CurrentCulture.Name}");
                Console.WriteLine($"Símbolo da moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
                Console.WriteLine($"{int.Parse("R$50000", NumberStyles.AllowCurrencySymbol)}");
                // retorna -200 mesmo com o símbolo de  negativo -
                Console.WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");
                // retorna 200 mesmo com os espaços em      branco antes e depois
                Console.WriteLine($"{int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");

                // retorna 5432123456
                Console.WriteLine($"{Int64.Parse("5432123456")}");
                Console.WriteLine($"Data: {DateTime.Parse("21 / 4 / 2021"):dd / MMM / yyyy}");

                ///////////// converões utilizando  to.convert 

                // Conversões com Convert.To
                Console.WriteLine("-----Convert Números”");
                int n1 = Convert.ToInt16("100");
                Console.WriteLine($"{n1.GetType()} - {n1}");

                Int32 n2 = Convert.ToInt32("200500");
                Console.WriteLine($"{n2.GetType()} - {n2}");

                Int64 n3 = Convert.ToInt64("1003232131321321");
                Console.WriteLine($"{n3.GetType()} - {n3}");

                decimal preco = Convert.ToDecimal("1420, 50");
                Console.WriteLine($"{preco.GetType()} - {preco: n2}");


                Console.WriteLine("-----Convert String");
                string texto1 = Convert.ToString(250.59M);
                Console.WriteLine($"{texto1.GetType()} -  {texto1} - resultado:  {texto1 ?? "texto é nulo"}");

                string texto2 = Convert.ToString(DateTime.Today);
                Console.WriteLine($"{texto2.GetType()} - {texto2}");


                Console.WriteLine("-----Convert Boleano");
                bool valido = Convert.ToBoolean("false");
                Console.WriteLine($"{valido.GetType()}- {valido}");
                Console.WriteLine($"0 - {Convert.ToBoolean(0)}");
                Console.WriteLine($"1 - {Convert.ToBoolean(1)}");
                Console.WriteLine($"100 - {Convert.ToBoolean(100)}");
                Console.WriteLine("----Convert Data");
                DateTime natal = Convert.ToDateTime("25 / 12 / 2021");
                Console.WriteLine($"Natal:  {natal.GetType()}-  {natal: dd /  MMMM / yyyy}");
                Console.WriteLine($"Natal:  {natal.Day} - {natal.Month}- {natal.Year}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
