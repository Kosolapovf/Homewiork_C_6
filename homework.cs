﻿/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

/* Console.Clear();
Console.Write("Введите числа: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
        count++;
Console.WriteLine($"[{String.Join(", ", array)}] -> {count}");
 */

/* 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


/* void Input()
{
    Console.Write("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x};{y})");
}
Console.Clear();
Input(); */