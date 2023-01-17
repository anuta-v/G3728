// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

// int num1 = int.Parse(Console.ReadLine()??"0");
// int num2 = int.Parse(Console.ReadLine()??"0");

// if (num1*num1==num2)
// {
//     Console.WriteLine("Первое число квадоат второго");
// }
// ifelse (num2*num2==num1)
// {

// } Код не дописан



// Console.WriteLine("input yor nums: ");
// // Вводим данные с консоли
// int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
// int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
// //сравнение возведённого в квадрат числа с другим числом
// if ((int)Math.Pow(num1, 2) == num2)
// {
//     Console.Write("да, число "+num2+" является степенью числа "+num1);//вывод согласия
// }
// else
// {
//     if ((int)Math.Pow(num2, 2) == num1)
//     {
//         Console.Write("да, число "+num1+" является степенью числа "+num2);//вывод согласия
//     }
//     else
//     {
//         Console.Write("Нет, числа "+num1+" и "+num2+" не являются чьей либо степенью");//вывод не согласия
//     }
// }

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");
TestSQRT(num1, num2);
TestSQRT(num2, num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.Write("число " + i + " является степенью числа " + j);//вывод согласия
    }
    else
    {
        Console.Write(" число " + i + " не является степенью числа " + j);
    }
}