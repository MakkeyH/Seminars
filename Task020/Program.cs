// double d = 5.099864545;
// // int n = (int)d; - // преобразования нецелого числа в целое;
// double dRound = Math.Round(d , 2); // функция Math.Round позволяет округлить число,
// // где в скобках d - целое число, а 2 - до скольки знаков необходимо округлить число после запятой;
// // в данном случае ответ будет - 5,1 (т.к. числа после запятой приравнивают в большую сторону,т.е. к 1)
// double dRound = Math.Round(d , 2, MidpointRounding.ToZero); // здесь мы получим 5,09 - то, 
// // что изначально нам  необходимо
// Console.WriteLine(dRound);

// double sqrt = Math.Sqrt(5); // - функция, позволяющая извлечь корень из заданного числа;
// Console.WriteLine(sqrt);
// Math.Pow(23, 5); // функция, позволяющая возвести число в какую-либо степень , где 23 - само число, 
// // 5 - в какую степень желаем возвести данное число.


// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double dist = Distance(a1, b1, a2, b2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}
Console.WriteLine($"Расстояние между координатами A и B - {distRound}");


