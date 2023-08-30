// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Random rand = new Random();
// int number = rand.Next(100, 1000);
// Console.WriteLine($"Cлучайное число - {number}");

// int result = Finish(number);
// Console.WriteLine($"Конечное число - {result}");

// int Finish(int num)
// {
//     int firstDigit = num / 100;
//     int thirdDigit = num % 10;
//     return firstDigit * 10 + thirdDigit;
// }

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Cлучайное число - {number}");

void FinishNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    Console.WriteLine($"Конечное число - {result}");
}

FinishNumber(number);



