// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if(-100 <= number && number <= 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
{
    int result = ThirdRank(number);
    int ThirdRank(int num)
    {
    while(number > 999)
    {
        num /=10;
    }
    return num % 10;
    }
    Console.WriteLine($"Третья цифра числа {number} - {result}"); 
}


 
