// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите числo M: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числo N: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int FillArray(int num, int num2)
{
    int[] arr = new int[arr.Length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(num, num2 + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");

    }
}

int FindSumElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i <= arr.Length; i++)
    {
        checked
        {
            sum = arr[i] + arr[i + 1];
        }
    }
    return sum;
}

int[] array = FillArray(1, 15);

int sum = FindSumElements(number);
Console.WriteLine($"Сумма чисел от {number} до {number2} = {sum}");

FillArray(array);
PrintArray(array);
Console.WriteLine();

FindSumElements(array);

