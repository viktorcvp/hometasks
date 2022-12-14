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


//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа

void scndCount(int num)
{
    int result = (num % 100 - num % 10) / 10;
    System.Console.WriteLine("второе число" + result);
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


scndCount(num);




//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.


Console.WriteLine("введите число ");
int x = Convert.ToInt32(Console.ReadLine());
string str = x.ToString();
if (x < 100) Console.WriteLine(" третьeй цифры нет");
else Console.WriteLine(" третья цифра" + str[2]);


//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите число дня недели");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 6 | x == 7) Console.WriteLine("день выходной");
else Console.WriteLine("день не выходной");

//Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


void palind()
{
    string palindrome(long num)
    {
        string result;
        int j = 0;
        int k = 0;
        string mutable = Convert.ToString(num);
        if (mutable.Length % 2 != 0) k = 1;
        for (int i = 0; i < mutable.Length / 2; i++)
        {
            if (mutable[i] == mutable[mutable.Length - i - 1]) j++;
        }
        if (j * 2 + k == mutable.Length) result = "Число палиндром";
        else result = "Число не палиндром";
        return result;
    }
    try
    {
        System.Console.Write("Введите число = ");
        long num = Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine(palindrome(num));
    }
    catch
    {
        System.Console.WriteLine("Введено не число, или число больше, чем можно вместить ");
    }
}

palind();
//Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

void graphic()
{
    double Distance(int N)
    {
        // Задаем координаты точки №1
        int[] first = new int[N];
        for (int i = 0; i < N; i++)
        {
            System.Console.Write("Введите координату первой точки на оси ==");
            first[i] = Convert.ToInt32(Console.ReadLine());
        }
        // Задаем координаты точки №2
        int[] second = new int[N];
        for (int i = 0; i < N; i++)
        {
            System.Console.Write("Введите координату второй точки на оси ==");
            second[i] = Convert.ToInt32(Console.ReadLine());
        }
        //Находим расстояние
        double sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum = sum + Math.Pow((second[i] - first[i]), 2);
        }
        sum = Math.Round(Math.Sqrt(sum), 2);
        return sum;
    }
    try
    {
        System.Console.Write("Введите число точек==");
        int N = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Distance(N));
    }
    catch
    {
        System.Console.WriteLine("Введено не число, или число больше, чем может вместить");
    }
}
graphic();

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cub()
{
    string cube(int num)
    {
        string result = $"{num} -> 1";
        for (int i = 2; i <= num; i++)
        {
            result = result + $", {Math.Pow(i, 3)}";
        }
        return result;
    }
    try
    {
        System.Console.Write("Введите число = ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        System.Console.WriteLine(cube(num));
    }
    catch
    {
        System.Console.WriteLine("Вводите целочисленное значение");
    }
}



//Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

void degree()
{
    double power(double A, int B) // Решение через цикл
    {
        double result = 1;
        int i = 1;
        while (i <= B)
        {
            result = result * A;
            i++;
        }
        return result;
    }
    try
    {

        System.Console.Write("Введите число A = ");
        double a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Введите число степени B = ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(a + " в степени " + b + " = " + power(a, b));
    }
    catch
    {
        System.Console.WriteLine("Введено не число, или число больше, чем может вместить int");
    }
}
degree();

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void sum()
{
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    int SumNumber(int numberN)
    {

        int counter = Convert.ToString(numberN).Length;
        int advance = 0;
        int result = 0;

        for (int i = 0; i < counter; i++)
        {
            advance = numberN - numberN % 10;
            result = result + (numberN - advance);
            numberN = numberN / 10;
        }
        return result;
    }

    int sumNumber = SumNumber(numberN);
    Console.WriteLine("Сумма цифр в числе: " + sumNumber);
}
sum();

//Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N 
//- вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.

void arra()
{
    int[] mass(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            System.Console.Write($"Введите {i + 1} элемент массива = ");
            mass[i] = Convert.ToInt32(Console.ReadLine());
        }
        return mass;
    }
    try
    {
        System.Console.Write("Введите число = ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Создан массив из " + a + " элементов со следующими значениями: " + String.Join(", ", mass(a)));
    }
    catch
    {
        System.Console.WriteLine("Введено не число, или число больше, чем может вместить int");
    }
}
arra();

//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void even()

{
    int[] FIllArray(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            mass[i] = new Random().Next(100, 1000);
        }
        return mass;
    }
    int even(int[] mass)
    {
        int i = 0;
        foreach (var item in mass)
        {
            if (item % 2 == 0) i++;
        }
        return i;
    }
    System.Console.Write("Введите размерность массива = ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] newMass = FIllArray(N);
    System.Console.WriteLine("Получился следующий массив:");
    System.Console.WriteLine(String.Join("|", newMass));
    System.Console.WriteLine($"Четных элементов в массиве: {even(newMass)}");

}
even();

//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
void odd()
{


    int[] FIllArray(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            mass[i] = new Random().Next(1, 100);
        }
        return mass;
    }
    int evenSum(int[] mass)
    {
        int sum = 0;
        foreach (var item in mass)
        {
            if (Array.IndexOf(mass, item) % 2 > 0)
            {
                sum += item;
            }
        }
        return sum;
    }
    System.Console.Write("Введите размерность массива = ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] newMass = FIllArray(N);
    System.Console.WriteLine("Получился следующий массив:");
    System.Console.WriteLine(String.Join("|", newMass));
    System.Console.WriteLine($"Сумма элементов на нечетных индексах равна : {evenSum(newMass)}");
}
odd();

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void difference()
{
    double[] FIllArray(int N)
    {
        double[] mass = new double[N];
        for (int i = 0; i < N; i++)
        {
            mass[i] = Math.Round(new Random().NextDouble() * 100, 2);
        }
        return mass;
    }
    double diff(double[] mass)
    {
        double res;
        int max = 0;
        int min = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > mass[max]) max = i;
            if (mass[i] < mass[min]) min = i;

        }
        res = mass[max] - mass[min];
        System.Console.WriteLine($"Наибольший элемент = {mass[max]}");
        System.Console.WriteLine($"Наименьший элемент = {mass[min]}");
        return res;
    }
    System.Console.Write("Введите размерность массива = ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] newMass = FIllArray(N);
    System.Console.WriteLine("Получился следующий массив:");
    System.Console.WriteLine(String.Join("|", newMass));
    System.Console.WriteLine($"Разница между наибольшим и наименьшим элементами массива : {Math.Round(diff(newMass), 2)}");
}
difference();

// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine($"Введи количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massNum = new int[m];

void Numbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введи {i + 1} число: ");
        massNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] massNum)
{
    int count = 0;
    for (int i = 0; i < massNum.Length; i++)
    {
        if (massNum[i] > 0) count += 1;
    }
    return count;
}

Numbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massNum)} ");



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void intersection()
{
    double[] crossPt(double k1, double k2, double b1, double b2)
    {
        double[] result = new double[2];
        result[0] = (b1 - b2) / (k2 - k1);
        result[1] = k1 * result[0] + b1;
        return result;
    }
    System.Console.Write(" введите коэфициент k1 ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write(" введите коэфициент b1 ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write(" введите коэфициент k2 ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write(" введите коэфициент b2 ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double[] answer = crossPt(k1, k2, b1, b2);
    System.Console.WriteLine($"Точка пересечения = {answer[0]},  Y = {answer[1]}");
}
intersection();

//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
//Задача 50: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine("таблица среднеарифметическое столбцов");
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите размер квадратного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 10;
int maxNumber = 99;
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];

Console.Clear();
FillArrayRandomNumber(testArray, minNumber, maxNumber);
PrintArrayWithIdex(testArray);

void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

*/

Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
void NumberCounter(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter(number - 1);
}

NumberCounter(number);

/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

/*
 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}










