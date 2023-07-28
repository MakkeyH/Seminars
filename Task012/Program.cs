// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите два целых числа"); // Первый вариант решения (без метода)
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1 % num2; 
// if(result == 0) Console.WriteLine($"Первое число кратно второму");
// else Console.WriteLine($"Первое число не кратно второму, остаток от деления {result}");


Console.WriteLine("Введите два целых числа"); // Второй вариант решения (через метод)
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Remains(num1, num2);

if(result == 0) Console.WriteLine($"Первое число кратно второму");
else Console.WriteLine($"Первое число не кратно второму, остаток от деления {result}");

int Remains(int number1, int number2)
{
    return number1 % number2;
}
