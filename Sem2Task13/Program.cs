﻿// Задача 13
//  Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

// Cчитываем число которое преобразуется в массив
char[] digit = (Console.ReadLine()??"0").ToCharArray();

// Проверям, что в числе больше трех цифр
if (digit.Length >2)
{
    Console.WriteLine(digit[2]);  // Вывод на консоль третьей цифры
}
else
{
    Console.WriteLine("Третьей цифры нет");
}