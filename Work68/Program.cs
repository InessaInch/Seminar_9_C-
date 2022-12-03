/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int getNumberFromUser(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int m = getNumberFromUser("Введите число М: ");
int n = getNumberFromUser("Введите число N: ");

PrintAkkermanFunction(m, n);

int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAkkermanFunction(m - 1, 1);
    }
    else
    {
        return (GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1)));
    }
}
void PrintAkkermanFunction(int m, int n)
{
    Console.Write("Результат функции: ");
    Console.Write(GetAkkermanFunction(m, n));
}


