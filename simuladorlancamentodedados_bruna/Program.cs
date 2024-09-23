using System;

public class Program
{
	public static void Main()
	{
		int numero;
		Random random = new Random();
		returnone:
			numero = random.Next(1, 7);
		Console.WriteLine($"o dado caiu no numero: {numero} ");
		returntwo:
			Console.Write("quer jogar o dado novamente? (s/n): ");
		string texto = Console.ReadLine();
		if (texto == "s")
		{
			goto returnone;
		}
		else if (texto == "n")
		{
			Console.WriteLine("encerrando aplicação");
			
		}
		else
		{
			Console.WriteLine("opção inválida. tente novamente! ");
			goto returntwo;
		}
	}
}