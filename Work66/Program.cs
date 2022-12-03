/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/ 

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumOfNumbers(m, n);
        return result;
    }
}
void PtintSumFromMToN(int m, int n)
{
    Console.Write("Сумма чисел в заданном промежутке: ");
    Console.Write(SumOfNumbers(m - 1, n));
}
PtintSumFromMToN(m, n);

