﻿// Напишите программу, которая на вход принимает\
// трехзначное число и на выходе показывает последнюю цифру 
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра числа: {result}");
}
else
{
    Console.WriteLine($"{number} - НЕ трёхзначное число");
}
