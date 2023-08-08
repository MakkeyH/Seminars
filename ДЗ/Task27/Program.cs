// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigit(number);
Console.WriteLine($"Cумма цифр в числе {number} = {result}");

int SumDigit(int num)
{
    int sumDigit = 0;
    while (num != 0)
    {
        sumDigit += num % 10;
        num /= 10;
    }
    return sumDigit;
}
 