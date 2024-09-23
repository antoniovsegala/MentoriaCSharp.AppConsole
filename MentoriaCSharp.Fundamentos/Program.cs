using MentoriaCSharp.Fundamentos.Fundamentos.Modulo._1;
using MentoriaCSharp.Fundamentos.Mensageria;
//A instancia é um ato de criar um novo objeto
//Exemplo objeto usuario do tipo usuario --- (O nome do objeto tem que ser sugestivo)
//O comando new Usuario() sinaliza a criação de um novo objeto
//A partir do nome do objeto acessamos seus dados

Saudacao saudacao = new Saudacao();
Usuario usuario = new Usuario(); //
saudacao.ExibirSaudacao();



//Console.WriteLine("qual a sua idade?");
//usuario.VerificaMaioridade(Convert.ToInt16(Console.ReadLine()));

//Console.Clear();
Console.WriteLine("Digite seu login");
usuario.VerificarUsuario(Console.ReadLine());

Console.Clear();

Console.WriteLine("Digite a sua senha");
usuario.VerificarSenha(Console.ReadLine());





