// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (-100 <= number && number <= 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    while(number >= 999)
    {
        int result = ThreeDigit(number);
        int ThreeDigit(int num)
        {
            int threeDigit = num / 10 % 10;
            return threeDigit;
        }
        Console.WriteLine($"Третья цифра числа {number} - {result}");
    }
}