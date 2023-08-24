// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool Triangle(int s1, int s2, int s3)
{
    if (s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2) return true;
    else return false;
}

Console.WriteLine("Ввведите три числа: ");
int side1 = Convert.ToInt32(Console.ReadLine());
int side2 = Convert.ToInt32(Console.ReadLine());
int side3 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(side1, side2, side3);
Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");






