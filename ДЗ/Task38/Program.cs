// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDbl(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 2)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 2);
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum} ");
    }
    Console.Write("]");
}

double MinMaxElementsArray(double[] arr)
{
    double minel = arr[0];
    double maxel = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minel) minel = arr[i];
        if (arr[i] > maxel) maxel = arr[i];
    }
    return maxel - minel;
}

double[] array = CreateArrayRndDbl(8, -20, 16);
PrintArrayDouble(array, 2);

double result = MinMaxElementsArray(array);
Console.WriteLine($"=>{Math.Round(result, 2)}");

