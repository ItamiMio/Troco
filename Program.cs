Console.Write("Digite o valor da compra: ");
double valorCompra = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorCompra;
Console.WriteLine($"O troco é: {troco:F2}");

