/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int numberM = ReadInt("Введите M: ");
int numberN = ReadInt("Введите N: ");

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}
int sum=0;
for(int i=numberM; i<=numberN; i++)
{
    sum += i;
}

Console.WriteLine(sum);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
