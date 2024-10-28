using MentoriaCSharp.Fundamentos.Enumeracao;
namespace MentoriaCSharp.Fundamentos.SvcFuncionario
{
    public class SvcFuncionario
    {
        //criar metodos relacionado ao funcionario aqui

        public void VrfTipoFuncionario(ETipoFuncionario tipoFuncionario)
        {
            if (ETipoFuncionario.Gerente == tipoFuncionario)
            {
                Console.WriteLine("Gerente.");
            }           
        }
    }
}
