﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double k1, k2, b1, b2;
Console.Write("Введите k1: ");
while (!Double.TryParse(Console.ReadLine(), out k1))
{
    Console.Write("Ошибка! Введите число: ");
}
Console.Write("Введите b1: ");
while (!Double.TryParse(Console.ReadLine(), out b1))
{
    Console.Write("Ошибка! Введите число: ");
}

Console.Write("Введите k2: ");
while (!Double.TryParse(Console.ReadLine(), out k2))
{
    Console.Write("Ошибка! Введите число: ");
}
Console.Write("Введите b2: ");
while (!Double.TryParse(Console.ReadLine(), out b2))
{
    Console.Write("Ошибка! Введите число: ");
}

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
