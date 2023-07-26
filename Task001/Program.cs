// Напишите программу, которая 
// 1. на вход принимает два числа
// 2. и проверяет,является ли первое число квадратом второго

// Например:
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -3 -> yes
// a = -3, b = 9 -> no

Console.WriteLine("Введите два целых числа");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number == number2 * number2)
{
    Console.WriteLine($"Число {number} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number} не является квадратом числа {number2}");
}

