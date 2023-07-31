// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if(100 <= number && 1000 > number || -100 >= number && -1000 < number)
{
int result = SecondDigit(number); 
Console.WriteLine($"Вторая цифра числа {number} - {result}");
 int SecondDigit(int num)
 {
    int secondDigit = num / 10;
    return secondDigit % 10;
 }
}
else Console.WriteLine($"Число {number} нам не подходит");