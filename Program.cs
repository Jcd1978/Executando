//Executando
ExibirOlaMundo();
ExibirMensagemEmAzul("Olá, meu nome é Zezinho");


string nomeDoUsuario = LerNomeDoUsuario();


ExibirMensagemEmAzul($"Seu nome é {nomeDoUsuario}");


//Declarando
void ExibirOlaMundo()
{
   ExibirMensagemEmAzul("Hello, World!"); 
}


void ExibirMensagemEmAzul(string mensagem)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue; 
    Console.WriteLine(mensagem);
    Console.ResetColor();
}


string LerNomeDoUsuario()
{
    Console.Write("Informe seu nome: ");
    string nome = Console.ReadLine()!;
    return nome;
}