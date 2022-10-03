// Задача № 1
//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.Write(n + " ");
    PrintNumbers(n - 1);
}
int n = Prompt("Введите число: ");
PrintNumbers(n);

// Задача № 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных чисел = {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);
}

// Задача № 3
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int functionAckerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAckerman}");

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}





