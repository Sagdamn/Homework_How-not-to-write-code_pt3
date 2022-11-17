﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

Console.WriteLine("Введите число M от которого считать");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число N до которого считать");
int n = int.Parse(Console.ReadLine() ?? "");

void GetNumberSumm(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
        return;
    }
    sum = sum + (m++);
    GetNumberSumm(m, n, sum);
}
GetNumberSumm(m, n, 0);