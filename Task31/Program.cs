﻿// Задача 31: 
// 1.Задайте массив из 12 элементов, 
// 2.заполненный случайными числами из промежутка [-9, 9]. 
// 3.Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]} ");

//     }
//     Console.Write("]");
// }

// int[] GetSumPositiveNegativeElem(int[] arr)
// {
//     int sumNegative = 0;
//     int sumPositive = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sumNegative += arr[i];
//         else sumPositive += arr[i];
//     }
//     return new int[] { sumNegative, sumPositive };
// }

// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int GetSumNegativeElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"Сумма отрицательных элементов  = {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[1]}");

// int sumPositiveElem = GetSumPositiveElem(array);
// int sumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine($"Сумма отрицательных элементов  = {sumNegativeElem}");
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");

int size = 12;
int[] array = new int[size];


void FillArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] arr)
{
    Console.Write(" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write(" ] ");
}


void GetSumPositiveNegativeElem(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    Console.WriteLine($"Сумма отрицательных элементов массивва  - {sumNegative}");
    Console.WriteLine($"Сумма положительных элементов массива - {sumPositive}");
}

FillArray(array, -9, 9);

PrintArray(array);
Console.WriteLine();

GetSumPositiveNegativeElem(array);



