﻿// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Please, input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = N%10;
Console.WriteLine($"Last digit = {result}");