/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int numberM = 1;
int numberN = ReadInt("Введите N: ");

Console.WriteLine(NumbersMaxMin(numberN, numberM));

int NumbersMaxMin(int n, int m)
{
    if (m == n)
        return m;
    else
    {
        Console.Write(NumbersMaxMin(n, m + 1) + ", ");
    }
    return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
