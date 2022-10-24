
Console.Clear();

// // семинар 1. домашнее задание.

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее.

// int a = -9;
// int b = -3;

// int max = a;

// if (a > b) max = a;
// if (b > a) max = b;

// Console.Write("max = ");
// Console.WriteLine(max);

Console.WriteLine("Вводим первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) max = b;

Console.WriteLine("max = ");
Console.WriteLine(max);




