// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите целое натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable(n);
void SquareTable(int num)
{
    for (int i = 1; i <= num;i++)
    {
        int square = i*i;
        Console.WriteLine($"{i, 3}  {square, 5}");
    }
}
