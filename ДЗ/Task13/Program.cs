﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// if(-100 < number && number < 100)
// {
//     Console.WriteLine($"У числа {number} нет третьей цифры");
// }
// else
// {
//     int result = ThirdRank(number);
//     int ThirdRank(int number)
//     {
//     while(number > 999 || -999 > number)
//     {
//         number /=10;
//     }
//     return number % 10;
//     }
//     Console.WriteLine($"Третья цифра числа {number} - {result}"); 
// }

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());


void ThirdNum(int num)
{
    // string num = Console.ReadLine();
    // // string num = "2345";

    // if (num.Length > 2) Console.WriteLine(num[2]); // третий символ строки - второй элемент массива;
    // else Console.WriteLine("У числа нет третьей цифры");

    while (num / 1000 > 0)
    {
        num /= 10;
        Console.WriteLine(num);
    }
    Console.WriteLine(num % 10);
}

ThirdNum(number);




