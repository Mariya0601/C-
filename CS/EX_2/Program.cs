﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNum(int m, int n)
{
    if (n < m) return 0;
    else return n + SumNum(m, n - 1);
}

void Main()
{
    Console.Clear();
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(SumNum(m, n));
}

Main();
