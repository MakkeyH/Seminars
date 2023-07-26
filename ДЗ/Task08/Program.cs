// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.Write($"Число{number} нам не подходит");
}
else
{
    int count = number;
    if (count % 2 == 0)
    {
        // Console.Write($"{count} - Чётное число");
        count = count - 0;
    }
    else if (count % 2 != 0)
    {
        // Console.Write($"{count} - Нечётное число");
        count = count - 1;
    }
}


