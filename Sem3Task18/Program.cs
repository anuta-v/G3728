// Задача №18
// Напишите программу, которая по заданному номеру четверти, показывает
//  диапазон возможных координат точек в этой четверти (x и y).

int qNum = ReadData("Введите номер четверти");


PrintQuterAnswer(qNum);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам точки

void PrintQuterAnswer(int num)
{
if (num > 0 && num < 5)
{
    if (qNum == 1) Console.WriteLine("x>0, y>0");
    if (qNum == 2) Console.WriteLine("x>0, y<0");
    if (qNum == 3) Console.WriteLine("x<0, y<0");
    if (qNum == 4) Console.WriteLine("x<0, y>0");
}
else
{
    Console.WriteLine("Это не номер четверти");
}
}
