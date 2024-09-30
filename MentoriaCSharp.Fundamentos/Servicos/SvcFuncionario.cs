using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.SvcUsuario
{
    internal class SvcFuncionario
    {
        //criar metodos relacionado ao funcionario aqui
        //verificar se o usuario é funcionario

        public void VrfTipoUsuario(string tipoUsuario)
        {
            if (tipoUsuario == "vendedor")
            {
                Console.WriteLine("Logado como Funcionário.");
            }
            else if (tipoUsuario == "proprietario")
            {
                Console.WriteLine("Logado como Proprietário.");
            }
            else
            {
                Console.WriteLine("O tipo de usuário esta incorreto.");
            }
        }
    }
}
