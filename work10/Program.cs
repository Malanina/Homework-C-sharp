Console.Clear();

// // семинар 3. домашнее задание.

// // Задача 21: Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    Console.Write(Math.Pow(i, 3) + ",");
}
Console.Write(Math.Pow(n, 3));


