using MentoriaCSharp.Fundamentos.Entidades;
//A instancia é um ato de criar um novo objeto
//Exemplo objeto usuario do tipo usuario --- (O nome do objeto tem que ser sugestivo)
//O comando new Usuario() sinaliza a criação de um novo objeto
//A partir do nome do objeto acessamos seus dados
#region Saudação
//Saudacao saudacao = new Saudacao();
//saudacao.ExibirSaudacao();
#endregion


#region exemplo

//Console.WriteLine("Digite seu login");
//string usrLogin = Console.ReadLine();

//Console.WriteLine("Digite a sua senha");
//string senha = Console.ReadLine();

//Usuario novoUsuario = new Usuario();
//novoUsuario.Nome = usrLogin;
//novoUsuario.Senha = senha;

#endregion
//Estudar a Entidade e a classe de serviço para o usuario


List<Usuario> usuarios = new()
{
    new Usuario{Nome = "Pedro",Senha = "123456"},
    new Usuario{Nome = "Joao", Senha = "789456"},
    new Usuario{Nome = "Antonio", Senha = "589632"},
    new Usuario{Nome = "Eduardo", Senha = "789632"},
    new Usuario{Nome = "Augusto", Senha = "782169"}
};
// Verificar nome e senha a partir que um usuario digite 
// Fazer validação usuario e senha
// Usar lógica
foreach (var usuario in usuarios)
{
    Console.WriteLine(usuario.Nome + usuario.Senha);
}

//criar tres tipos de lista
//int, string e objeto 
