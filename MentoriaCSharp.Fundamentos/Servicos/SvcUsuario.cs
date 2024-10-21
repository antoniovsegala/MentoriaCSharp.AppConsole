using MentoriaCSharp.Fundamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Servicos
{
    public  class SvcUsuario
    {

        public static void VerificarUsuario(string nomeUsuario, string senha)
        {
            string? msgUsuario;
            if (nomeUsuario == "Antonio" && senha == "aa1234")
            {
                msgUsuario = "login efetuado";
            }
            else if (nomeUsuario == "Antonio" || senha == "aa1234")
            {
                msgUsuario = "alguma credencial está incorreta";
            }
            else
            {
                msgUsuario = "Usuário não existe";
            }
            Console.WriteLine(msgUsuario);
        }

        public void VerificaMaioridade(int idade)
        {

            if (idade <= 12)
            {
                Console.WriteLine("criança");
            }
            else if (idade <= 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade <= 60)
            {
                Console.WriteLine("adulto");
            }
            else
            {
                Console.WriteLine("idoso");
            }

        }
    }
}
