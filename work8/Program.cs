Console.Clear();

// // семинар 3. домашнее задание.

// // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000;
int b = number % 10000 / 1000;
int c = number % 1000 / 100;
int d = number % 100 / 10;
int e = number % 10;

if (a == e && b == d)
    Console.WriteLine("Число является палиндромом");

else
    Console.WriteLine("Число не является палиндромом");
