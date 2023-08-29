// Напишите программу, которая на вход принимает
// одно число (N),а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> -4,-3,-2,-1,0,1,2,3,4
// 2 -> -2,-1,0,1,2


// Console.WriteLine("Введите целое натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());
// // for(int i = -number;i <= number;i++)  // 1ый вариант решения
// // {
// //     Console.Write($"{i} ");
// // }
// if (number <= 0) // 2ой вариант решения
// {
//     Console.Write("Число не натуральное");
// }
// else
// {
//     int count = -number;
//     while (count <= number)
//     {
//         Console.Write($"{count} ");
//         count++;
//     }
// }

Console.WriteLine("Введите число: "); // вариант решения с помощью функции
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); // функция,возвращающая абсолютное значение числа
int count = -number;
while (count <= number)
{
    Console.Write(count + " ");
    count++;
}




