// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            fact = fact *= i; // fact = fact * i;
        }
    }
    return fact;
}

// 2ой вариант решения
// int CompositionNumbers(int num)
// {
//  int composition = 1;
//  while (num !=0)
//  {
//  checked
//  {
//  composition *= num;
//  num--;
//  }
//  }
//  return composition;
// }


