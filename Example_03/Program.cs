﻿/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int num1 = new Random().Next(50, 100);
int num2 = new Random().Next(1, 50);

Console.WriteLine(num1);
Console.WriteLine(num2);

 double num3 = num1 % num2;

if (num3>0)
{
Console.WriteLine("не кратно, остаток "+num3);
} 
else
Console.WriteLine("кратно");