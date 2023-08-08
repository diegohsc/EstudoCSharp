using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    class PrimeiraClasse
    {

        static void Main(string[] args)
        {
            InteracaoUsuario user = new InteracaoUsuario();
            user.SolicitarDigitacao();
            user.MostrarDigitacao();

        } 
    }

        class InteracaoUsuario
        {
            private string _mensagemDigitada;

            public String Mensagem
            {
                get { return _mensagemDigitada; }
                set { _mensagemDigitada = value; }
            }

            public void SolicitarDigitacao()
            {
                Console.WriteLine("entre com um valor");
                _mensagemDigitada =  Console.ReadLine();
            }

            public void MostrarDigitacao()
            {
                Console.WriteLine($"O valor digitado foi: {_mensagemDigitada} ");
            }
        }
    
}
