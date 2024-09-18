decimal valorCompra, valorPago, valorTroco;
Console.WriteLine("---Troco---");
Console.WriteLine("Valor da compra (R$):");
valorCompra = Convert.ToDecimal(Console.ReadLine());
Console.Write("valor pago (R$)");
valorPago = Convert.ToDecimal(Console.ReadLine());
valorTroco = valorPago - valorCompra;
Console.WriteLine($"Troco: {valorTroco:C}");