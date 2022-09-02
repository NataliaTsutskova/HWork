// Задача № 1

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) {
    System.Console.WriteLine($"Наибольшее число равно {a}");
}
else {
    System.Console.WriteLine($"Наибольшее число равно {b}");
}


// Задача № 2

System.Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число z: ");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;

if(max < y) {
    max = y;
}
if(max < z) {
    max = z;
}
System.Console.WriteLine($"Наибольшее число равно {max}");


//Задача № 3

System.Console.Write("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) {
    System.Console.WriteLine("Число чётное");
}
else {
    System.Console.WriteLine("Число нечётное");
}


// Задача № 4

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while(i <= n) {
    if(i % 2 == 0) {
    System.Console.WriteLine(i);
    }
    i++;
}