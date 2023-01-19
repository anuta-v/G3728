﻿// Задача 15
//  Напишите программу, которая принимает на вход цифру, обозначающую 
//  день недели, и проверяет, является ли этот день выходным.

//Считываем с консоли число
int day = int.Parse(Console.ReadLine() ?? "0");

// Проверяем, что число от 1 до 7
if ((day > 7) || (day < 1))
{
    Console.WriteLine("Это не день недели");
}
else
{
    if (day > 5)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
}