using System;

class Program
{
	public static void Main(string[] args)
	{
		int num1 = 0;
		int num2 = 0;
		Console.WriteLine("Calculadora básica");
		Console.WriteLine("------------------\n");
		Console.WriteLine("Insira um número e aperte enter: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Insira outro número e aperte enter novamente: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Escolha a operação: ");
		Console.WriteLine("\ta - Adição");
		Console.WriteLine("\ts - Subtração");
		Console.WriteLine("\tm - Multiplicação");
		Console.WriteLine("\td - Divisão");
		switch (Console.ReadLine())
		{
			case "a":
				Console.WriteLine($"Seu resultado é: {num1} + {num2} = " + (num1 + num2));
				break;
			case "s":
				Console.WriteLine($"Seu resultado é: {num1} - {num2} = " + (num1 - num2));
				break;
			case "m":
				Console.WriteLine($"Seu resultado é: {num1} * {num2} = " + (num1 * num2));
				break;
			case "d":
				Console.WriteLine($"Seu resultado é: {num1} / {num2} = " + (num1 / num2));
				break;
		}
	}
}
