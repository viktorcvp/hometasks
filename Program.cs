﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число b");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    Console.WriteLine(a + "больше" + b);
}

else Console.WriteLine("число" + b + "больше" + a);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("введите первое число v");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число d");
int d = Convert.ToInt32(Console.ReadLine());

if (v > n)
{
    Console.WriteLine(v + "больше" + n);
}

else if (n > v) Console.WriteLine("число" + n + "больше" + v);

