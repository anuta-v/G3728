// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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
double[] Gen1DArray(int len, double begin, double end)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return arr;
}


// Метод печати созданного массива на консоль
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double MinMax(double[] arr)
{
double min = Int32.MaxValue;
double max = Int32.MinValue;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}


int len = ReadData("Введите длину массива: ");
double b = ReadData("Введите начало массива: ");
double e = ReadData("Введите окончание массива: ");
double[] testArr = Gen1DArray(len, b, e);
Print1DArr(testArr);
double result = MinMax(testArr);
PrintData("Разница между максимальным и минимальным значениями: " + result);
