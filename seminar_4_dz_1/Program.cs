﻿// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

double Numbers(double a, int b)
{
  double result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}
Console.WriteLine("Натуральная степень: "+Numbers(A,B));
