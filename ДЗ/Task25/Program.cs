// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int degree = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Math.Pow(number,degree));
if (degree > 0) Console.WriteLine($"Число {number} в степени {degree} = {pow}"); 
else Console.WriteLine("Некорректные данные");