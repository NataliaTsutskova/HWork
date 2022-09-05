// Задача № 1

int n = new Random().Next(100, 1000);
System.Console.WriteLine(n);

int sd = n / 10 % 10;
System.Console.WriteLine($"Вторая цифра числа {n} равна {sd}");

// Задача № 2

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int td = num / 100 % 10;

if (td > 0)
{
    System.Console.WriteLine($"Третья цифра числа {num} равна {td}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

// Задача № 3

int d = new Random().Next(1, 8);
System.Console.WriteLine(d);

if (d <= 5)
{ 
    System.Console.WriteLine("Данный день недели не является выходным");
}
else
{
    System.Console.WriteLine("Данный день недели является выходным");
}
