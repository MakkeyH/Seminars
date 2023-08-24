// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(BinaryNumber(number));

int BinaryNumber(int num)
{
    int outNum = 0;
    int i = 0;
    while (num > 0)
    {
        outNum += num % 2 * (int)Math.Pow(10, i);
        i++;
        num /= 2;
    }
    return outNum;
}

