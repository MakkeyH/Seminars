// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int weekday = Weekday(a);
if(0 < a && a <=7)
{
bool Weekday(int num)
{
    if (num == 1) return weekday;
    if (num == 2) return weekday;
}
Console.WriteLine(weekday ? "Выходной,ура!" : "Рабочий день");
}
else Console.WriteLine("{a} - не является днём недели");
