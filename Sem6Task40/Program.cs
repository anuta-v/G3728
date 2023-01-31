// Задача №40 
// Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.


// Метод считывает данные с консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void Triangle (int a, int b, int c)
{
if ((a+b>c) && (b+c>a) && (a+c>b))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}
}


int a = ReadData("Введит первое число: ");
int b = ReadData("Введит второе число: ");
int c = ReadData("Введит третье число: ");
Triangle(a,b,c);