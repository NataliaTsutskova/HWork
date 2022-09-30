// Задача № 1
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random Rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Rnd.Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] OrderArrayDigits(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}
int[,] MyArray = GenerateArray(3, 4, 0, 10);
Console.WriteLine("Исходный массив:");
PrintArrayMatrix(MyArray);
Console.WriteLine("Упорядоченный массив:");
PrintArrayMatrix(OrderArrayDigits(MyArray));

// Задача № 2
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random Rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Rnd.Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int LineNumberSmallestSum(int[,] array)
{
    int minSum = array[0, 0];
    int lineMinSum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            lineMinSum = i;
        }
    }
    return lineMinSum + 1;
}

int[,] MyArray = GenerateArray(3, 4, -9, 10);
Console.WriteLine("Заданный массив:");
PrintArrayMatrix(MyArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {LineNumberSmallestSum(MyArray)}");


// Задача № 3
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random Rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Rnd.Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] firstArray = GenerateArray(5, 3, 1, 10);
System.Console.WriteLine("Первая матрица:");
PrintArrayMatrix(firstArray);
int[,] secondArray = GenerateArray(3, 3, 1, 10);
System.Console.WriteLine("Вторая матрица:");
PrintArrayMatrix(secondArray);
if (firstArray.GetLength(1) != secondArray.GetLength(0))
{
    Console.WriteLine("Умножение невозможно");
}
else
{
    Console.WriteLine("Результат умножения матриц:");
    PrintArrayMatrix(MultiplyMatrix(firstArray, secondArray));
}

// Задача № 4
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GenerateArray3D()
{
    int[,,] array = new int[2, 2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                array[i, j, k] = (int)(Math.Pow(i + 1, 3) + Math.Pow(j + 2, 3) + Math.Pow(k + 3, 3));
            }
        }
    }
    return array;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Console.Write($"{array[i, j, k],3} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}
PrintArray3D(GenerateArray3D());

// Задача № 5
// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



