﻿// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите целое число");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine($"{day} -> Понедельник");
}
else if(day == 2)
{
    Console.WriteLine($"{day} -> Вторник");
}
else if(day == 3)
{
    Console.WriteLine($"{day} -> Среда");
}
else if(day == 4)
{
    Console.WriteLine($"{day} -> Четверг");
}
else if(day == 5)
{
    Console.WriteLine($"{day} -> Пятница");
}
else if(day == 6)
{
    Console.WriteLine($"{day} -> Суббота");
}
else if(day == 7)
{
    Console.WriteLine($"{day} -> Воскресенье");
}
else if(day < 1 | day > 7)
{
    Console.WriteLine($"{day} -> Не является днем недели");
}









