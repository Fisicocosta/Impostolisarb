// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("----------------------------------------------------------------------Imposto de LISARB-----------------------------------------------------");

double salario;

double imposto;

Console.WriteLine("Digite o valor do salário.");

salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario == 0.0)

{
    Console.WriteLine("Isento");

}

else if (salario > 0.0 && salario <= 2000.00)

{
    Console.WriteLine("Isento");

}

else if (salario > 2000.00 && salario <= 3000.00)

{

    imposto = (salario - 2000.00) * 0.08;
    Console.WriteLine(" O imposto devido é de R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

}

else if (salario > 3000.00 && salario <= 4500.00)

{

    imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
    Console.WriteLine("O imposto devido é de R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

}

else if(salario > 4500.00)

{

    imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000 * 0.08;
    Console.WriteLine("O imposto devido é de R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

}