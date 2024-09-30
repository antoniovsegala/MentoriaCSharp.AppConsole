using MentoriaCSharp.Fundamentos.Entidades;
//A instancia é um ato de criar um novo objeto
//Exemplo objeto usuario do tipo usuario --- (O nome do objeto tem que ser sugestivo)
//O comando new Usuario() sinaliza a criação de um novo objeto
//A partir do nome do objeto acessamos seus dados
#region Saudação
//Saudacao saudacao = new Saudacao();
//saudacao.ExibirSaudacao();
#endregion




Console.WriteLine("Digite seu login");
string usrLogin = Console.ReadLine();

Console.WriteLine("Digite a sua senha");
string senha = Console.ReadLine();

Usuario novoUsuario = new Usuario();
novoUsuario.Nome = usrLogin;
novoUsuario.Senha = senha;


//Estudar a Entidade e a classe de serviço para o usuario




