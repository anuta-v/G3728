﻿// Задача № 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).

string? inputNum = Console.ReadLine();

// Проверяем чтобы данные не были пустыми
if (inputNum != null)
{
    //Парсим введеное число
    int num = int.Parse(inputNum);

    // Проверяем остаток от деления
    if (num % 2 == 0)

    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }
}