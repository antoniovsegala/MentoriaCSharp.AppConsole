using MentoriaCSharp.Fundamentos.Entidades;
using MentoriaCSharp.Fundamentos.Servicos;
using MentoriaCSharp.Fundamentos.SvcUsuario;
using MentoriaCSharp.Fundamentos.SvcFuncionario;
//A instancia é um ato de criar um novo objeto
//Exemplo objeto usuario do tipo usuario --- (O nome do objeto tem que ser sugestivo)
//O comando new Usuario() sinaliza a criação de um novo objeto
//A partir do nome do objeto acessamos seus dados
#region Saudação
//Saudacao saudacao = new Saudacao();
//saudacao.ExibirSaudacao();
#endregion


// Verificar nome e senha a partir que um usuario digite 
// Fazer validação usuario e senha
// Usar lógica

#region login

string nmUsuario = "";
string snha = "";

Console.WriteLine("Digite seu login");
nmUsuario = Console.ReadLine();

Console.WriteLine("Digite a sua senha");
snha = Console.ReadLine();


SvcUsuario.VerificarUsuario(nmUsuario, snha);



#endregion
//Estudar a Entidade e a classe de serviço para o usuario




//criar tres tipos de lista
//int, string e objeto 
//Criar enum para tipos de usuario
