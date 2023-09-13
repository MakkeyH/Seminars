// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите числo M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числo N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumNumbers(num1, num2 - 1);
    else return num2 + SumNumbers(num1, num2 + 1);
}

Console.WriteLine($"Сумма чисел от {number1} до {number2} = {SumNumbers(number1, number2)}");
    
