// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (9999 >= number && number < 99999)
{
    Console.WriteLine($"Число {number} нам не подходит");
}
else
{
    int first = number / 10000;
    int second = number / 1000 % 10;
    int fourth = number / 10 % 10;
    int fifth = number % 10;
    if (first == fifth && second == fourth)
    {
        Console.WriteLine($"{number} является палиндромом");
    }
    else Console.WriteLine($"{number} не является палиндромом");
}

