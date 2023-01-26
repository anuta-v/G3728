// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.WriteLine(msg2);
}

int SumSym (int num)
{
    int res = 0;
    while(num>0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}


// Считываем данные с консоли
int num = ReadData("Введите число: ");

// Обращаемся к методу суммирования цифр
int res = SumSym(num);

// Выводим результат на консоль
PrintData($"Cумма цифр числа {num} равна ",res);