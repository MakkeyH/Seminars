// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5-> 1,4,9,16,25
// 2-> 1,4

Console.WriteLine("Введите целое натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int square = i * i;
        Console.Write($"{square} ");
    }
}

SquareTable(n);
