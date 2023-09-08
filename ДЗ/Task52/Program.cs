// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); j++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticSumofColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); i++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = sum + array / matrix.GetLength(0);
        }
    }
    return array[j];
}

int[,] array2d = CreateMatrixRndInt(4, 6, -50, 65);
PrintMatrix(array2d);
Console.WriteLine();

double[] result = Math.Round(ArithmeticSumofColumn(array[j]), 1);
PrintMatrix(result);

