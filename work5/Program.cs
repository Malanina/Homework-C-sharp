Console.Clear();

// // семинар 2. домашнее задание.

// // Задача 10: Напишите программу, которая принимает на вход трехзначное число, а на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// Console.WriteLine($"{number/10%10}");


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

Console.WriteLine($"{number/10%10}");
