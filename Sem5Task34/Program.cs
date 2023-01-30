// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2.

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

// Метод считает количество четных чисел в массиве
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

//Метод проверяет четное ли число
bool Test(int n)
{
    return (n%2==0);
}

int len = ReadData("Введите длину массива: ");
int[] testArr = Gen1DArray(len,100,999);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество четных элементов: "+count);