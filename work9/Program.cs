Console.Clear();

// // семинар 3. домашнее задание.

// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите Х первой точки");
int userXa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки");
int userYa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки");
int userZa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Х второй точки");
int userXb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки");
int userYb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки");
int userZb = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt((userXa - userXb) * (userXa - userXb) + (userYa - userYb) * (userYa - userYb) + (userZa - userZb) * (userZa - userZb));
Console.WriteLine($"Расстояние между точками равно {d}");

