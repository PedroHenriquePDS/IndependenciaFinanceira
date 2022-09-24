System.Console.Write("Insira seu gasto mensal: ");

decimal gastos = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Insira a taxa de juros mensal do investimento (%): ");

decimal rendimentos = (Convert.ToDecimal(Console.ReadLine())/100);

decimal investimento = Convert.ToDecimal(gastos/rendimentos);
Console.ForegroundColor = ConsoleColor.Red;
System.Console.Write($"Para receber {gastos} ");
System.Console.Write($"por mês com rendimentos de {rendimentos*100:N2}% ");
System.Console.WriteLine($"você precisa ter investido {investimento:C}");
Console.ResetColor();

System.Console.WriteLine();
System.Console.Write("Pressione uma tecla para fechar...");
Console.ReadKey();
