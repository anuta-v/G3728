// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Метод считывает данные с консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных на консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод создания нового массива случайных элементов
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод печати созданного массива на консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод сууммирует элементы, стоящие на нечетных позициях
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
    return res;
}


int len = ReadData("Введите длину массива: ");
int b = ReadData("Введите начало массива: ");
int e = ReadData("Введите окончание массива: ");
int[] testArr = Gen1DArray(len, b, e);
Print1DArr(testArr);
int result = SumPos(testArr);
PrintData("Сумма элементов, стоящих на нечетных позициях: " + result);