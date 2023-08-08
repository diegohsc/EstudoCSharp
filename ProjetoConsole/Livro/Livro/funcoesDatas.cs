using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
     class funcoesDatas
    {
        
       static void Main(string[] args)
        {

            int dia = 12;
            int mes = 05;
            int ano = 2021;
            

            //  DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtAniversario = new DateTime(1986,08,20);
          //  DateTime dtFesta = new DateTime(2021, 08,25);
            Console.WriteLine("------Funções de Datas------ -");
            Console.WriteLine($"Aniversário: { dtAniversario}");
            Console.WriteLine($"Aniversário: { dtAniversario: dd /MM / yyyy}");
            Console.WriteLine($"Aniversário: { dtAniversario: ddd / MMM / yyyy}");
            Console.WriteLine($"Aniversário: { dtAniversario: dddd dd / MMMM / yyyy}");

            DateTime hoje = DateTime.Today;
            Console.WriteLine("“TODAY - retorna a data atual");
            Console.WriteLine($"TODAY: { hoje: dd / MM / yyyy}");
            DateTime DataHora = DateTime.Now;
            Console.WriteLine("NOW - retorna a data e a hora atual");
            Console.WriteLine($"Data  e  Hora:  {DataHora: dd / MM /yyyy hh: mm: ss}");

            Console.WriteLine($"DATA ATUAL: {hoje: dd/MM/yyyy}");
            Console.WriteLine($"Hora: {DataHora:hh:mm:ss}");

            Console.WriteLine($"Dia: {hoje.Day} mes: {hoje.Month} ano`{hoje.Year}");

            //adicionar dias meses e anos a datas 

            DateTime dtPedido = DateTime.Today;
            // adiciona 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);
            // adicionar 2 meses
            DateTime dtPagto = dtVencto.AddMonths(2);

            Console.WriteLine($"Formatação  completa:{ dtVencto.ToLongDateString()}");
            Console.WriteLine($"Formatação  curta:  {dtVencto.ToShortDateString()}");
            // dia da semana
            Console.WriteLine($"dia da semana: { dtVencto.DayOfWeek}");
            Console.WriteLine($"dia do semana em português: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Número  do dia da  semana:  { (int)dtVencto.DayOfWeek}");
            // dia do ano
            Console.WriteLine($"dia do ano: { dtVencto.DayOfYear}");

            // subtrai 2 datas
            var qtdeDias = dtPagto.Subtract(dtPedido);


            //// converão de datas ..
            ///
            Console.WriteLine("Conversão de Texto para Date");
            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;
            // tentativa (TryParse) de conversão de dataTexto
            // caso dê certo a saída OUT será em dataTextoCo
            if (DateTime.TryParse(dataTexto, out dataTextoConvertida))
            {
                Console.WriteLine("Data com conversão aceita");
                  }
            else
            {
                Console.WriteLine("Erro na conversão da data");
            }
               
            string dataTextoErrada = "15 / metade do ano / 2021";
            DateTime dataTextoErradaConvertida;
            if (DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
                Console.WriteLine("Data com conversão aceita");
            else
                Console.WriteLine("Erro na conversão da data");


            //////uso de datas com objetos.

            Pedido pedido = new Pedido
            {
                PedidoID = 1,
                DtPedido = DateTime.Today,
                DtPagto = DateTime.Today.AddDays(45),
                Valor = 1500
            };

            Console.WriteLine($"Pedido: {pedido.PedidoID}");
            Console.WriteLine($"{pedido.DtPedido:dd / MMM / yyyy}");
            Console.WriteLine($"vencto:{pedido.DtVencimento():dd/MM/yyyy}");
            Console.WriteLine($"dias atraso: {pedido.DiasAtraso().TotalDays}");
            Console.WriteLine($"valor: {pedido.Valor:n2}");
            Console.WriteLine($"multa: {pedido.Multa:n2}");
   
        }


    }

    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto { get; set; }
        public TimeSpan DiasAtraso() => DtPagto.Subtract(DtVencimento());
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;

    }

}



