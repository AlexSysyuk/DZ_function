﻿// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число некратно 7 и 23");
// }
//
// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0
// и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
//
// Console.WriteLine("Введите координаты точки x, y через пробел: ");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x == 0 && y == 0)
// {
//     Console.WriteLine("Введите ненулевые значения координат");
// }
// if (x == 0 && y != 0 )
// {
//     Console.WriteLine("Точка находится на оси координат Y");
// }
// if (y == 0 && x != 0)
// {
//     Console.WriteLine("Точка находится на оси координат X");
// }
// else
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в I четверти плоскости");
//     }
//     if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится в II четверти плоскости");
//     }
//     if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится в III четверти плоскости");
//     }
//     if (x < 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в IV четверти плоскости");
//     }
// }
//
// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
//
// Console.Write("Введите число из отрезка [10, 99]: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10 && number <= 00) 
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
//     Console.WriteLine(maxDigit);
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }
//
// Задача 4: Напишите программу, которая
// на вход принимает натуральное число N, а
// на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}