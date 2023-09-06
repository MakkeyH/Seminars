// int[] array = new int[8]; // 0 1 2 3 4 5 6 7 (по умолчанию массив заполняется нулями)
// int[] array1 = { 5, 6, 7, 9 };//2ой вариант написания массива;
// int[] array2 = new int[] { 5, 6, 7, 9 };//3ий вариант написания массива;
// int[] array3 = new int[8] { 5, 6, 7, 9, 5, 7, 8, 8 };//4ый вариант написания массива;
// var array4 = new int[8];//5ый вариант написания массива;

// array[4] = 454;  //пример присваивания значения по индексу,индекс - 4,число в массиве под 4ым индексом - 454
// // array[9] = 444;
// Console.WriteLine(array[7]);
// for (int i = 0; i < array1.Length; i++)
// {
//     // array[i] = i * i;
//     Console.Write(array1[i] + " ");
// }

// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArr(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}

FillArr(array);
PrintArr(array);
