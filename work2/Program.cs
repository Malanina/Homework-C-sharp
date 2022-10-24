Console.Clear();

// // семинар 1. домашнее задание.

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

// int a = 22;
// int b = 3;
// int c = 9;

// int max = a;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// Console.Write ("max = ");
// Console.WriteLine (max); 


Console.Write("Вводим  первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводим  второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводим  третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine(max);
