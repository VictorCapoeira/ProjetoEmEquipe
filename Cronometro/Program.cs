using System.Diagnostics;
using System.Threading;
//Chamando bibliotecas necessarias para construir  a aplicação!
Console.WriteLine("Insira a quantidade de tempo em segundos: ");
//Perguntando ao user a quantidade de tempo em segundos que ele deseja. 
int tempo = int.Parse(Console.ReadLine());
// Criando variavel do tipo int para armazenar o valor do tempo em segundos
Stopwatch cronometro = new Stopwatch();
// Criando instancia em cronometro. Assim será possivel usar os metodos e atributos de Stopwatch()
cronometro.Start();
// Inicinando a "contagem"
while(true){
    // Forçando execução do loop
    Console.Clear();
    //Usando o clear para limpar toda vez que o loop ocorrer. Na pratica, ele irá fazer com que apenas um resultado seja visivel, emulando a sensação de que o tempo está correndo de forma direta;
    TimeSpan tempoReal = cronometro.Elapsed;
    //Usand Elapsed é possivel obter o tempo decorrido(o valor é retornad)
    Console.Write($"{tempoReal.Hours:D2}:{tempoReal.Minutes:D2}:{tempoReal.Seconds:D2}");
    //Exibindo para o user o tempo em horas, minutos e segundos
    if(tempoReal.TotalSeconds >= tempo){
        //Quando o tempo deseja for atingndo, tal bloco será executado:
        cronometro.Stop();
        //Encerrand a contagem
        break;
        //Encerrando a execução
    }
    Thread.Sleep(1000);
    //Na prática, está suavizando a execução

    

}  

