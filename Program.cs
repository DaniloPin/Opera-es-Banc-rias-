ContaBancaria conta = new ContaBancaria("34235", 1000.00);

conta.Depositar(100.00);

Console.WriteLine($"Conta: {conta.NumeroConta} ");
Console.WriteLine($"Saldo atual: {conta.Saldo.ToString("F2")}");

