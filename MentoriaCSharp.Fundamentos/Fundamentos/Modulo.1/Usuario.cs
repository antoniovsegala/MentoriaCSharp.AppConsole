using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Fundamentos.Modulo._1
{
    
    public class Usuario
    {
        //Programa que verifique a maior idade do usuario
        // Espera que o usuário digite sua idade
        // Resultado diz se é criança, adolescente, adulto ou idoso.
        int idade;
        string? nomeUsuario;
        string? senha;


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
            else if(idade <= 60)
            {
                Console.WriteLine("adulto");
            }
            else
            {
                Console.WriteLine("idoso");
            }

        }

        public void VerificarUsuario(string nomeUsuario)
        {
            if (nomeUsuario == "Antonio")
            {
                Console.WriteLine("Usuario efetuado");
            }
            else if (nomeUsuario != "Antonio")
            {
                Console.WriteLine("Usuario incorreto");
            }
        }
        
        public void VerificarSenha(string senha)
        {
            if (senha == "aa1234")
            {
                Console.WriteLine("login efetuado");
            }
            else if(senha != "aa1234")
            {
                Console.WriteLine("senha incorreta");
            }

        }
    }
}
