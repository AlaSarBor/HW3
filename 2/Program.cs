﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double k1 = Convert.ToInt32(Console.ReadLine()!);
double k2 = Convert.ToInt32(Console.ReadLine()!);
double b1 = Convert.ToInt32(Console.ReadLine()!);
double b2 = Convert.ToInt32(Console.ReadLine()!);
double x = -((b1 - b2) / (k1 - k2));
double y = k1 * x + b1;
System.Console.WriteLine($"({x};{y})");
