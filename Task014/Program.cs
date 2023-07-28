// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
bool result = Multiplicity(a);

Console.WriteLine(result ? "Кратно" : "Не кратно");

bool Multiplicity(int number)
{
    return number % 7 == 0 && a % 23 == 0; 
}

