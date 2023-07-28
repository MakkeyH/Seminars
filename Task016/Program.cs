// /16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
bool result = Square(a, b);

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
Console.WriteLine(result ? "Одно из чисел является квадратом другого числа" : "Не является квадратом другого числа");