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
            List<Usuario> usuarios = new()
            {
                new Usuario{Nome = "Pedro",Senha = "123456"},
                new Usuario{Nome = "Joao", Senha = "789456"},
                new Usuario{Nome = "Antonio", Senha = "589632"},
                new Usuario{Nome = "Eduardo", Senha = "789632"},
                new Usuario{Nome = "Augusto", Senha = "782169"}
            };

            var listaUsuarios = usuarios;
            //ajustar bug
            //foreach dentro de outro foreach
            //Não usar gpt
            foreach (Usuario usuario in usuarios)
            {
                if (nomeUsuario == usuario.Nome && senha == usuario.Senha)
                {
                    Console.WriteLine("Login Efetuado");
                    return;
                }else
                {
                    Console.WriteLine("Login Incorreto");
                    return;
                };

            }


            //string? msgUsuario;
            //if (nomeUsuario == "Antonio" && senha == "aa1234")
            //{
            //    msgUsuario = "login efetuado";
            //}
            //else if (nomeUsuario == "Antonio" || senha == "aa1234")
            //{
            //    msgUsuario = "alguma credencial está incorreta";
            //}
            //else
            //{
            //    msgUsuario = "Usuário não existe";
            //}
            //Console.WriteLine(msgUsuario);
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
