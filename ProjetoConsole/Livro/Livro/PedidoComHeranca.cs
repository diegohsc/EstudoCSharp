using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class PedidoComHeranca
    {
        static void main(string[] args)
        {

            InteracaoUsuario user = new InteracaoUsuario();
            user.SolicitarDigitacao();
            user.MostrarDigitacao();

            string msg = user.Mensagem;

            Console.WriteLine(msg);


        }

       
    }
}
