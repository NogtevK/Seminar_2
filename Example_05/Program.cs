﻿/* 13. Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что
третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/

/* int num1 = 125;
int num2 = num1 % 10;

while (num1 > 999)
{
    num1 = num1 / 10;
}
if (num1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(num1 % 10);
} */

/////////////second solution
string str=Console.ReadLine();
int num=int.Parse(str);

Console.WriteLine(str[2]);