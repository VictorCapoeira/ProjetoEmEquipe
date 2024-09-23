

Console.WriteLine("informe o tamanho da senha: ");
int.TryParse(Console.ReadLine(), out int tamanho);
//usuário inserir o tamanho da senha

char[] caracteresvalidos = {'a', 'e', 'i', 'o', 'u', 'b', 'c', 'd', 'f', 'g', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', '!', '@', '#', '$', '%', '&', '*', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
//caracteres permitidos para senha

Random x = new Random();
//inicialização da função Random
string senha = "";
//string para armazenar a senha
{
    for(int i = 0; i<tamanho; i++)
    //quantidade de caracteres que irá ter na senha
    {
        char carac = caracteresvalidos[x.Next(caracteresvalidos.Length)];
        //geração de senha aleatoriamente, puxando os caracteres do array
        senha += carac;
        //adicionando os caracteres na variável
    }
    Console.Write(senha);
    //exibição da variável
}
