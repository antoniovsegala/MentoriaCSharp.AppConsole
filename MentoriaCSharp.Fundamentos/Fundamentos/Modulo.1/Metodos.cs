using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Fundamentos.Modulo._1
{
    internal class Metodos
    {
        string cpf = "";//variavel global existe em toda extensão da classe.

        public string ExemploMetodoComRetorno()
        {
            string carregaCpf = "000.222.444.05"; // variavellocal existe apenas equanto o método é executado

            return carregaCpf;
        }

        public void ExemploMetodoComParametros(string? variavel, int valor)
        {
            cpf = ExemploMetodoComRetorno();
            Console.WriteLine($"{valor}, {variavel}, {cpf}");

        }
        
        
        
        
        
           
        //Função nunca espera um retorno
        //Metodo espera ou não um retorno
        //Procedimento não espera um metodo e normalmente é usado no "program"
    }
}
