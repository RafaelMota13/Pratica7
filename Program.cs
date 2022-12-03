﻿decimal valorSaque, valorRestante;
int n200, n100, n50, n20, n10, n5, n2, n1;

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("*----- Caixa Eletrônico -----*\n");
Console.ResetColor();

Console.Write("Digite o valor que será sacado: ");
valorSaque = Convert.ToDecimal(Console.ReadLine());

if (valorSaque <= 0)
    {

        Console.Write("\nO valor ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"{valorSaque}");
        Console.ResetColor();
        Console.WriteLine(" não pode ser sacado  ;(\n");
        return;
        
     
    }

if (valorSaque % 1 > 0)
    {

        Console.WriteLine("Este caixa não trabalha com moedas !");

    }

valorRestante = valorSaque;

n200 = (int)(valorRestante / 200);
valorRestante = valorRestante % 200;

n100 = (int)(valorRestante / 100);
valorRestante = valorRestante % 100;

n50 = (int)(valorRestante / 50);
valorRestante = valorRestante % 50;

n20 = (int)(valorRestante / 20);
valorRestante = valorRestante % 20;

n10 = (int)(valorRestante / 10);
valorRestante = valorRestante % 10;

n5 = (int)(valorRestante / 5);
valorRestante = valorRestante % 5;

n2 = (int)(valorRestante / 2);
valorRestante = valorRestante % 2;

n1 = (int)(valorRestante / 1);
valorRestante = valorRestante % 1;

Console.WriteLine("\nO caixa deve entregar:");

if (n200 > 0) Console.WriteLine($"{n200} nota(s) de R$200,00");
if (n100 > 0) Console.WriteLine($"{n100} nota(s) de R$100,00");
if (n50 > 0) Console.WriteLine($"{n50} nota(s) de R$50,00");
if (n20 > 0) Console.WriteLine($"{n20} nota(s) de R$20,00");
if (n10 > 0) Console.WriteLine($"{n10} nota(s) de R$10,00");
if (n5 > 0) Console.WriteLine($"{n5} nota(s) de R$5,00");
if (n2 > 0) Console.WriteLine($"{n2} nota(s) de R$2,00");
if (n1 > 0) Console.WriteLine($"{n1} nota(s) de R$1,00");