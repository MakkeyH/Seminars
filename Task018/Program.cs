// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// string quarter = Console.ReadLine();

// string coordinates = Range(quarter);

// if (coordinates != null)
//     Console.WriteLine(coordinates);
// else Console.WriteLine("Некорректная четверть");

// string Range(string q)
// {
//     if (q == "1") return "x > 0 && y > 0";
//     if (q == "2") return "x < 0 && y > 0";
//     if (q == "3") return "x < 0 && y < 0";
//     if (q == "4") return "x > 0 && y < 0";
//     return null;
// }


Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

void Range(int q)
{
    if (q == 1)  Console.WriteLine("x > 0 && y > 0");
    else if (q == 2)  Console.WriteLine("x < 0 && y > 0");
    else if (q == 3)  Console.WriteLine("x < 0 && y < 0");
    else if (q == 4)  Console.WriteLine("x > 0 && y < 0");
    else Console.WriteLine("Некорректная четверть");
}

Range(quarter);

