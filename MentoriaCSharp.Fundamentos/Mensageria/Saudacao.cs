using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Mensageria
{
    internal class Saudacao
    {
        /// <summary>
        /// Método para exibir uma saudação ao usuário.
        /// </summary>
         public void ExibirSaudacao()
        {
            DateTime? HoraAtual;
            HoraAtual = DateTime.Now;
            string? saudacao;


            if (HoraAtual < DateTime.Parse("12:00"))
            {

                saudacao = "Bom dia, seja bem vindo";

            }
            else if (HoraAtual < DateTime.Parse("18:00"))
            {

                saudacao = "Boa tarde, seja bem vindo";

            }
            else
            {

                saudacao = "Boa Noite, seja bem vindo";
            }
            Console.WriteLine(saudacao);
        }

    }
}
