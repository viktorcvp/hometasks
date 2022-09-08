//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

void numMax()
{
    Console.WriteLine("введите первое число a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите второе число b");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите третье число с");
    int c = Convert.ToInt32(Console.ReadLine());

    if ((b > a) && (b > c)) Console.WriteLine($"max = {b}");
    else if (c > a && c > b) Console.WriteLine($"max = {c}");
    else Console.WriteLine($"max = {a}");
}
numMax();


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


void rest()
{
    Console.WriteLine("введите  число a");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0) Console.WriteLine("число четное");
    else if (a % 2 != 0) Console.WriteLine("число нечетное");


}
rest();


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

void res()
{
    Console.WriteLine("введите  число a");
    int a = Convert.ToInt32(Console.ReadLine());


    for (int i = 2; i < a; i++)
    {
        if (i % 2 == 0)
            Console.Write(i);
    }
}
res();
