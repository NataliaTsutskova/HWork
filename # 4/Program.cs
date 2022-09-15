// Задача № 1

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
}
Console.WriteLine(result);

// Задача 2

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (num > 0)
{
    sum += num % 10;
    num = num / 10;
}

Console.WriteLine(sum);


// Задача 3

int[] GetArray()
{
    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
PrintArray(GetArray());