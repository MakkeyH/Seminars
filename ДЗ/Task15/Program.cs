// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число");
int day = Convert.ToInt32(Console.ReadLine());
void Weekday(int d)
{
    if (d == 1) Console.Write($"{d} - Понедельник");
    else if (d == 2) Console.Write($"{d} -Вторник");
    else if (d == 3) Console.Write($"{d} - Среда");
    else if (d == 4) Console.Write($"{d} - Четверг");
    else if (d == 5) Console.Write($"{d} - Пятница");
    else if (d == 6) Console.Write($"{d} - Ура!Суббота!Выходной");
    else if (d == 7) Console.Write($"{d} - Ура!Воскресенье!Выходной");
    else Console.WriteLine("Такого дня недели не существует");
}

Weekday(day);
