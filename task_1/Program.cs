﻿// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7->max = 7
// // a = 2 b = 10->max = 10
// // a = -9 b = -3->max = -3

Console.Write ("Введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());
 int min = Math.Min(a, b);
int max = Math.Max(a, b);
Console.Write(string.Format("Min:{0} Max:{1}", min, max));