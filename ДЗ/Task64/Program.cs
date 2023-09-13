// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}

int NatureValue(int num)
{
    int result = 0;
    for (int i = num; i >= 1; i--)
    {
        result += i;
    }
    return result;
}

int result = NatureValue(number);
Console.Write($"N = {number} -> {result}");

