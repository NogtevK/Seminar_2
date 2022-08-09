/* 11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа. */

int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int c1 = num / 100; // 123/100=1
int c3 = num % 10; // 123%10=3

Console.WriteLine(c1+""+c3);