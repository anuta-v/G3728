// Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее

//Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if ((inputNum1 != null) && (inputNum2 != null))
{
    //     //Парсим введенное число
    int number1 = int.Parse(inputNum1);
    //     //Парсим введенное число
    int number2 = int.Parse(inputNum2);

// Cравниваем введенные числа
    if (number1 > number2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}