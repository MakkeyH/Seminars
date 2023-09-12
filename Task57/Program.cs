// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}

void NumDictionary(int[] arr)
{
    int currentNum = arr[0];
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == currentNum) count++;
        else
        {
            Console.WriteLine($"Элемент {currentNum} встречается {count} раз");
            currentNum = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элемент {currentNum} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 3, -9, 35);
PrintMatrix(array2d);
Console.WriteLine();

int[] array = MatrixToArray(array2d);
Array.Sort(array);
Console.WriteLine(string.Join(" ", array));

NumDictionary(array);