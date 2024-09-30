using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace MentoriaCSharp.Fundamentos.Entidades
{

    public class Usuario
    {
        int idade;

        public string? Nome { get; set; }
        public string Senha { get; set; }


        string? tipoUsuario;
    }
}
