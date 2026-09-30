Console.WriteLine("--- Decomposição Decimal ---");
Console.Write("Digite um número inteiro...: ");
int numero = int.Parse(Console.ReadLine());


int unidade = numero % 10;
int dezena = (numero / 10) % 10;
int centena = numero / 100; 
Console.WriteLine();

Console.WriteLine($"O número é composto por:");
Console.WriteLine($"Unidade: {unidade}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Centena: {centena}");



