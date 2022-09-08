// Задача № 1

System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}

// Задача 2

System.Console.WriteLine("Введите координаты первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
System.Console.WriteLine(result);

// Задача 3

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
