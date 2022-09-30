
// Задача 1

int[] GenerateArray()
{
    int[] result = new int[10];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
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
int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}
var array = GetArray();
PrintArray(array);
var EvenCount = CountEvenNumbers(array);
Console.WriteLine(EvenCount);


// Задача № 2

int[] GetArray()
{
    int[] result = new int[6];

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
int SumOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    return sum;
}
var array = GetArray();
PrintArray(array);
var Sum = SumOddNumbers(array);
Console.WriteLine(Sum);


// Задача № 3

double[] GetArray()
{
    double[] result = new double[10];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    Console.WriteLine();
}
double MinNum(double[] array)
{
    double Min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (Min >= array[i])
            Min = array[i];
    }
    return Min;
}
double MaxNum(double[] array)
{
    double Max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (Max <= array[i])
            Max = array[i];
    }
    return Max;
}
var array = GetArray();
PrintArray(array);

var MinNumber = MinNum(array);
var MaxNumber = MaxNum(array);

Console.WriteLine(MaxNumber - MinNumber);