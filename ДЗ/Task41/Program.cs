// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("- Сколько чисел вы хотите ввести?");
int count = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[count];

void ArrayNumbers()
{
    Console.WriteLine("Введите ваши числа: ");
    for (int i = 0; i < count; i++)
    {
        if (i > 0)
        {
            Console.Write("Ещё: ");
        }
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountNum()
{
    int count1 = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > 0)
        {
            count1++;
        }
    }
    return count1;
}

ArrayNumbers();
Console.WriteLine($"Вами введено чисел больше 0: {CountNum()}");

