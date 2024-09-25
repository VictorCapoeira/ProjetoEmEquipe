
Console.WriteLine("Olá, bem-vindo ao restaurante Prato Feito\n");
Console.WriteLine("Deseja realizar o pedido? Digite 1\nEscolher de forma aleatória? Digite 2");
string x = Console.ReadLine();
if (x == "1")
{

    Console.WriteLine("NOSSO CARDÁPIO:\n");
    Console.WriteLine("\nCARNES\n 1 - Picanha Bovina R$ 27,90\t\t3 - Fraldinha R$ 17,90\n 2 - Patinho R$ 15,00\t\t 4 - Frango a passarinho R$12,90");
        string carnis = Console.ReadLine().ToLower();
 
           
            double[] price = {0, 27.90, 17.90, 15, 12.90};
            double i = 0;

            if(carnis == "Picanha Bovina".ToLower() || carnis == "Picanha".ToLower())
            {
                 i = price[1];
                Console.WriteLine($"Picanha Bovina - R${price[1]}" );
            }
            else if(carnis == "Fraldinha".ToLower())
            {
                 i = price[2];
                Console.WriteLine($"Fraldinha - R$ {price[2]}");
            }
            else if(carnis == "Patinho".ToLower())
            {
                 i = price[3];
                Console.WriteLine($"Patinho - R$ {price[3]}");
            }
            else if(carnis == "Frango a passarinho".ToLower() ||carnis =="Frango".ToLower())
            {
                 i = price[5];
                Console.WriteLine($"Frango a passarinho - R$ {price[5]}");
            }
            else
            {
                 i = price[0];
                Console.WriteLine($"Sem carne - R$ {0}");
            }
            
        Console.WriteLine("\nAPERITIVOS\n 1 - Arroz R$ 5,00\t\t3 - Batata Frita R$ 12,00\n 2 - Salada R$ 5,00\t\t 4 - Farofa R$ 7,00");
        string aperi = Console.ReadLine().ToLower();
 
            string[] aperitivo = {"Sem aperitivo", "Arroz", "Salada", "Batata Frita", "Farofa"};
            double[] preco = {0, 5, 5, 12, 7};
            double p = 0;

            if(aperi == "Arroz".ToLower() )
            {
                p = preco[1];
                Console.WriteLine($"Arroz - R${preco[1]}");
            }
            else if(aperi == "Batata Frita".ToLower())
            {
                p = preco[4];
                Console.WriteLine($"Batata Frita - R$ {preco[4]}");
            }
            else if(aperi == "Salada".ToLower())
            {
                p = preco[2];
                Console.WriteLine($"Salada - R$ {preco[2]}");
            }
            else if(aperi == "Farofa".ToLower())
            {
                p = preco[3];
                Console.WriteLine($"Farofa - R$ {preco[3]}");
            }
            else
            {
                p = preco[0];
                Console.WriteLine($"Sem Aperitivo - R$ {0}");
            }

        Console.WriteLine($"seu pedido é R${i+p}");
}
else
{
            Random y = new Random();
            int sorteio = y.Next(0,5);

            string[] carne = {"Sem Carne", "Picanha Bovina", "Patinho", "Fraldinha", "Frango a passarinho"};
            double[] price = {0, 27.90, 17.90, 15, 12.90};
            double i = 0;

            if(sorteio== 4)
            {
                i = price[4];
                Console.WriteLine(carne[4]);
            }
            else if(sorteio==1)
            {
                i = price[1];
                Console.WriteLine(carne[1]);
            }
            else if(sorteio == 2)
            {
                i = price[2];
                Console.WriteLine(carne[2]);
            }
            else if(sorteio==3)
            {
                i = price[3];
                Console.WriteLine(carne[3]);
            }
            else
            {
                i =price[0];
                Console.WriteLine(carne[0]);
            }
        
 
            string[] aperitivo = {"Sem aperitivo", "Arroz", "Salada", "Batata Frita", "Farofa"};
            double[] preco = {0, 5, 5, 12, 7};

            double p = 0;
            int o =y.Next(1,5);

            if(o == 4)
            {
                p = preco[4];
                Console.WriteLine(aperitivo[4]);
            }
            else if(o==1)
            {
                p = preco[1];
                Console.WriteLine(aperitivo[1]);
            }
            else if(o == 2)
            {
                p = preco[2];
                Console.WriteLine(aperitivo[2]);
            }
            else if(o==3)
            {
                p = preco[3];
                Console.WriteLine(aperitivo[3]);
            }
            else
            {
                p =preco[0];
                Console.WriteLine(aperitivo[0]);
            }
            Console.WriteLine($"seu pedido deu = R${p+i}");
}
            

