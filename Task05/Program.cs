// Задача 5. Напишите программу вычисления значения функции возведения
// числа в квадрат.
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
OurPower(number); // вызов метода
OurPower(7);
OurPower(number + number);

void OurPower(int currentNumber) // метод , где скобки - тело метода, внутри скобок - 
// выполнение того или иного действия
{
    Console.WriteLine(currentNumber * currentNumber); // currentNumber - встроенная переменная,т.е. 
// параметр, принадлежащий переменной number 
}


// Console.WriteLine(Math.Pow(number, 2)); // Math.Pow - функция или метод, 
// позволяющий возводить число в ту или иную степень