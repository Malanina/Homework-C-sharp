Console.Clear();

// // семинар 2. домашнее задание.

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
if (str.Length > 2)
{
    Console.Write("Третья цифра числа" + str[2]);
}
else
{
    Console.Write("Третьей цифры нет");
}

