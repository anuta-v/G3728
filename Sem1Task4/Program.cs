// Задача №4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из 
// этих чисел.

//Считываем данные с консоли 1 число
string? Inputnum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? Inputnum2 = Console.ReadLine();
//Считываем данные с консоли 3 число
string? Inputnum3 = Console.ReadLine();

// Проверяем чтобы данные не были пустыми
if ((Inputnum1 != null) && (Inputnum2 != null) && (Inputnum3 !=null))
{
    //Парсим введенные числа
int num1 = int.Parse(Inputnum1);
int num2 = int.Parse(Inputnum2);
int num3 = int.Parse(Inputnum3);

// Сравниваем введенные числа
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num1);
    }
    else
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num3);
    }
}
else
{
    if (num2 > num3)
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num2);
    }
    else
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num3);
    }
}

}

