// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки и столбца в двумерном массиве: ");
int a = Convert.ToInt32(Console.ReadLine()); // первая позиция элемента будет строкой;
int b = Convert.ToInt32(Console.ReadLine()); // вторая позиция элемента будет столбцом;

if (a < 0 || b < 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
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
            Console.Write($"{matrix[i, j],8}");
        }
        Console.WriteLine();
    }
}

void ElementValue(int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    { Console.WriteLine(matrix[i-1, j-1]); }
    else Console.WriteLine("Такого элемента в массиве не существует");
}

int[,] array2d = CreateMatrixRndInt(3, 4, -67, 125);
PrintMatrix(array2d);
Console.WriteLine();

ElementValue(array2d, a, b);

