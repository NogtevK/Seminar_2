﻿/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа. */

int num = new Random().Next(10, 100);

Console.WriteLine(num);

int c1 = num / 10; //12345/10=1234
int c2 = num % 10; //12345%10=5

if (c1 > c2)
{
    Console.WriteLine(c1);
}
else
{
    Console.WriteLine(c2);
}