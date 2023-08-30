// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100); // 99+1
// Console.WriteLine($"Cлучайное число из отрезка 10-99 -> {number}");
// // int firstDigit = number / 10;  // как найти первую цифру в двухзначном числе
// // int secondtDigit = number % 10; // как найти вторую цифру в двухзначном числе
// // if (firstDigit > secondtDigit) // первый вариант решения
// // {
// //     Console.WriteLine($"{firstDigit} - наибольшая цифра числа {number}");
// // }
// // else
// // {
// //     Console.WriteLine($"{secondtDigit} - наибольшая цифра числа {number}");
// // }

// // int maxDigit = firstDigit > secondtDigit ? firstDigit : secondtDigit; // второй вариант решения
// // тернарный оператор, в котором первая часть уравнения задается равентством к максимальной переменной,
// // где знак (? == if) - "тогда когда", знак(: == else) - "иначе".
// // Console.WriteLine($"{maxDigit} - наибольшая цифра числа {number}");

// int result = MaxDigit(number);

// Console.WriteLine($"{result} - наибольшая цифра числа {number}");

// int result1 = MaxDigit(45);
// Console.WriteLine($"{result1} - наибольшая цифра числа {45}");

// int result2 = MaxDigit(87);
// Console.WriteLine($"{result2} - наибольшая цифра числа {87}");

// int result3 = MaxDigit(98);
// Console.WriteLine($"{result3} - наибольшая цифра числа {98}");

// int MaxDigit(int num) // метод решения для любых заданных переменных из данной задачи, где num -
// // параметр для данного метода
// {
//     int firstDigit = num / 10;
//     int secondtDigit = num % 10;
//     int maxDigit = firstDigit > secondtDigit ? firstDigit : secondtDigit; 
//     return maxDigit;
// }

Random rand = new Random();
int number = rand.Next(10, 100);

Console.WriteLine(number);
// 96 -> 96/10 = 9   96 % 10 = 6;

void MaxDigit(int num)
{
    
    int firstDigit = num / 10;
    int secondtDigit = num % 10;
    if (firstDigit > secondtDigit) Console.WriteLine(firstDigit);
    else if (secondtDigit > firstDigit) Console.WriteLine(secondtDigit);
    else Console.WriteLine($"Цифры числа {num} равны");
}

MaxDigit(number);