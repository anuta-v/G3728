// Задача 25:
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


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

int Pow (int A, int B)
{
    int res = 1;
    while (B > 0)
    {
        B=B-1;
        res = res*A;
    }
    return res;
}

// Считываем данные с консоли
int numA = ReadData("Введите число: ");
int numB = ReadData("Введите степень: ");

// Обращаемся к методу возведения в степень
int res = Pow(numA, numB);

// Выводим результат на консоль
PrintData($"Число {numA} в степени {numB} равно ",res);