Console.WriteLine("Conversor de temperatura!");
Console.Write("Insira o valor da temperatura: ");
double temp = double.Parse(Console.ReadLine());
string tempFin = "";
Console.Write("Insira a medida(f = Fahreinheit -- c - Celsius -- k - Kelvin: )");
string medi = Console.ReadLine().ToLower();
Console.Write("Escolha a conversão(insira o número correspondente):\n Conversões de Celsius  \n 1 - C --> F \n 2 - C --> K \n Conversões de Fahreinheit  \n 3 - F --> C  \n 4 - F --> K \n Conversões de Kelvin  \n 5 - K --> C \n 6 - K --> F \n ");
int tip = int.Parse(Console.ReadLine());
switch(tip){
    case 1:
    tempFin = $"{(1.8 * temp) + 32} F";
    break;
    case 2:
    tempFin = $"{temp + 273.15} K";
    break;
    case 3:
    tempFin = $"{(temp - 32) / 1.8} C";
    break;
    case 4:
    tempFin = $"{(temp - 32) * 5/9 + 273.15} K";
    break;
    case 5:
    tempFin = $"{temp - 273.15} C";
    break;
    case 6:
    tempFin = $"{(temp - 273) * 1.8 + 32} F";
    break;
}
Console.WriteLine($"Valor convertido: {tempFin}");

