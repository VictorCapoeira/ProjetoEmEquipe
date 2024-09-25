using System;

public class Program
{
	public static void Main()
	{
		returnone:
			Console.Write("insira seu peso (kg): ");
		if (!double.TryParse(Console.ReadLine(), out double peso))
		{
			Console.WriteLine("número inválido. Tente Novamente! ");
			goto returnone;
		}

		returntwo:
			Console.Write("insira sua altura (m): ");
		if (!double.TryParse(Console.ReadLine(), out double altura))
		{
			Console.WriteLine("número inválido. Tente Novamente! ");
			goto returntwo;
		}

		double imc = peso / (altura * altura);
		Console.WriteLine($"seu imc é: {imc:F2}\n");
		Console.WriteLine("possui algum dos problemas listados: ");
		Console.WriteLine("1-diabetes");
		Console.WriteLine("2-problemas nas articulações");
		Console.WriteLine("3-problemas cardiacos ");
		Console.WriteLine("4-obesidade");
		Console.WriteLine("5-dores nas costas ");
		Console.WriteLine("6-ansiedade ou estresse");
		returnthree:
			Console.Write("digite uma opção: ");
		int alternativa = int.Parse(Console.ReadLine());
		switch (alternativa)
		{
			case 1:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° Caminhadas rápidas ");
				Console.WriteLine("° natação");
				Console.WriteLine("° Treinamento de resistência (com pesos leves a moderados) ");
				Console.WriteLine("° Exercícios aeróbicos de baixa intensidade ");
				Console.WriteLine("° Yoga (ajuda no controle do estresse e glicemia) ");
				break;
			case 2:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° hidroginástica ");
				Console.WriteLine("° caminhadas leves ");
				Console.WriteLine("° ciclismo (com baixa resistência) ");
				Console.WriteLine("° alongamentos e yoga ");
				Console.WriteLine("° pilates (fortalecimento sem sobrecarga articular) ");
				break;
			case 3:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° caminhadas moderadas ");
				Console.WriteLine("° bicicleta leve ");
				Console.WriteLine("° natação ");
				Console.WriteLine("° exercícios de alongamento ");
				Console.WriteLine("° Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio)");
				break;
			case 4:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° Caminhadas e caminhadas rápidas ");
				Console.WriteLine("° Natação ");
				Console.WriteLine("° Exercícios em bicicleta ergométrica");
				Console.WriteLine("° Exercícios aeróbicos de baixo impacto ");
				Console.WriteLine("° Hidroginástica ");
				break;
			case 5:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° Caminhada em ritmo leve ");
				Console.WriteLine("° Natação ou hidroginástica ");
				Console.WriteLine("° Caminhada em ritmo leve ");
				Console.WriteLine("° Pilates (fortalecimento do núcleo) ");
				Console.WriteLine("° Exercícios de alongamento e mobilidade");
				break;
			case 6:
				Console.WriteLine("sugestões de exercícios: ");
				Console.WriteLine("° Yoga ");
				Console.WriteLine("° Tai Chi ");
				Console.WriteLine("° Meditação guiada (combinada com alongamentos)  ");
				Console.WriteLine("° Caminhadas ao ar livre  ");
				Console.WriteLine("° Dança (para liberar endorfina)");
				break;
			default:
				Console.WriteLine("opção inválida. Tente Novamente! ");
				goto returnthree;
		}
	}
}