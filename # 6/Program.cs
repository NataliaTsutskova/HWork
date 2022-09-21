// Задача № 1
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] GetArray()
{
    int[] result = new int[num];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    Console.WriteLine();
}

int CountPosNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}
var array = GetArray();
PrintArray(array);
var PosCount = CountPosNumbers(array);
Console.WriteLine(PosCount);


// Задача № 2

Console.WriteLine("Введите число b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

float x = (b1 - b2) / (k2 - k1);
float y = (k2 * b1 - k1 * b2) / (k2 - k1);
if (k1 == k2)
{
    System.Console.WriteLine("Прямые не пересекаются");
}
else
{
    System.Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");
}