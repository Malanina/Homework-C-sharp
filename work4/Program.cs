﻿
Console.Clear();

// // семинар 1. домашнее задание.

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N/


Console.Write("Вводим N: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= N)
{
    if (i % 2 == 0)

        Console.Write(i + " ");

    i++;
}

Console.WriteLine();



