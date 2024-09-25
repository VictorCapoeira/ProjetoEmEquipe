using System;

public class Program
{
	public static void Main()
	{
		Random random = new Random();
		int numeroSecreto = random.Next(1, 101);
		int tentativa;
		int contadorTentativas = 0;
		Console.WriteLine("tente adivinhar um numero entre 1 e 100:");
		do
		{
			Console.Write("digite seu palpite: ");
			tentativa = Convert.ToInt32(Console.ReadLine());
			contadorTentativas ++;
			
			//Console.Write(tentativa.CompareTo(numeroSecreto));
			switch (tentativa.CompareTo(numeroSecreto))
			{
				case < 0:
					Console.WriteLine("Muito baixo. Tente novamente. ");
					break;
				case> 0:
					Console.WriteLine("Muito alto. Tente novamente. ");
					break;
				case 0:
					Console.WriteLine($"Parabens! Voce acertou em {contadorTentativas} tentativas.");
					break;
			}
		}while (tentativa != numeroSecreto);
	}
}