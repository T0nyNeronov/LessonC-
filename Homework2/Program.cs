﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int GetFiguresSum(int res)
{
    int sum=0;
   while (res>0)
    {
        sum=sum+res%10;
        res/=10;
    }
    return sum;
    }
    Console.WriteLine("сумма цифр числа "+num+" равна "+GetFiguresSum(num));

            