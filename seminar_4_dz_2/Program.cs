﻿//  Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int sum = 0;
    int count = 0;

    while (count<=sum)
    {
        count++;
        sum +=count;
    }
    return sum;
}
Console.WriteLine(GetSumNum());