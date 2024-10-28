using MentoriaCSharp.Fundamentos.Enumeracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Entidades
{
    public class Funcioario
    {
        public ETipoFuncionario Tipo { get; set; }
        public DateTime DataContracao { get; set; }
        public bool Ativo { get; set; }
    }
}
