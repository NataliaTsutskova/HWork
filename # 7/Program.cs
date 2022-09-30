// // Задача № 1

// double[,] GenerateArray(int rows, int columns) 
// {
//     double[,] array =  new double[rows, columns];
//     Random Rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Rnd.NextDouble();
//         }
//     }
//     return array;
// }
// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// double[,] myarray = GenerateArray(3, 4);
// PrintArray(myarray);

// Задача № 2

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

(int, bool) FindElement(int[,] array, int line, int column)
{
    if (0 <= line && line < array.GetLength(0)
        && column >= 0 && column < array.GetLength(1))
    {
        return (array[line, column], true);
    }
    else
    {
        return (0, false);
    }
}

int LineNumber = Prompt("Введите номер строки:");
int ColumnNumber = Prompt("Введите номер столбца:");
int[,] MyArray = GenerateArray(3, 4, 0, 10);
PrintArrayMatrix(MyArray);
(int result, bool isExisted) = FindElement(MyArray, LineNumber, ColumnNumber);
if (isExisted)
{
    Console.WriteLine($"Элемент массива ({LineNumber}, {ColumnNumber})" + $" => {result}");
}
else{
    Console.WriteLine($"В массиве нет элемента с указанными позициями ({LineNumber}, {ColumnNumber})");
}

// // Задача № 3

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
    
// }
// void PrintArray(double[] arr)
// {
//     for (int i = 0; 1 < arr.Length; i++)
//     {
//         Console.WriteLine($"{arr[i]}\t");
//     }
//     Console.WriteLine();
// }
// void PrintArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[] ArithmeticMeanEachColumn(int[,] array)
// {
//     double sum = 0;
//     double[] arColum = new double [array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum += array[j, i];
//         }
//         arColum[i] = sum / array.GetLength(0);
//         sum = 0;
//     }
//     return arColum;
// }
// int[,] myArray = GenerateArray(3, 3, 0, 10);
// PrintArrayMatrix(myArray);
// double[] resultArray = ArithmeticMeanEachColumn(myArray);
// Console.WriteLine("Среднее арифметическое в каждом столбце массива:");
// PrintArray(resultArray);