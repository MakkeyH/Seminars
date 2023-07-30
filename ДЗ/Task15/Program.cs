// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if(0 < a <=7)
{
int weekday = Weekday(a);
bool Weekday(int num)
{
    return num == 6 && num == 7 || num !=6 && num !=7;
}
Console.WriteLine(weekday ? "Выходной,ура!" : "Рабочий день");
}
else Console.WriteLine("{a} - не является днём недели");
