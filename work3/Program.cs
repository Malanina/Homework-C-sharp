﻿Console.Clear();
// // семинар 1. домашнее задание.

// // Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Write("Вводим число: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 2 == 0)

        Console.WriteLine("Четное число");

else
        {
        Console.WriteLine("Нечетное число");
        }

