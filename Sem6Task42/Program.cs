// Задача №42 
// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101 
// 3 -> 11 
// 2 -> 10


// Метод считывает данные с консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string Convert10to2(int num)
{
    string result = string.Empty;
    while (num >=1)
    {
        result = Convert.ToString(num%2) + result;
        num = num / 2;
    }
    return result;
}

string result = Convert10to2(ReadData("Введите число: "));
Console.WriteLine(result);