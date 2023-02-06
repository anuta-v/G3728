// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//1) Получение данных от пользователя
int m = InputNum("Количество строк массива: ");
int n = InputNum("Количество столбцов массива: ");

//2) Генерация двумерного массива
int[,] matrix = FillTwoDimArray(m, n);

//3) Печатаем двумерный массив
PrintTwoDimArray(matrix);

double[] means = MeanColum(matrix);
Print1DArr(means);

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 50);
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            // Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
            //col[new System.Random().Next(0,16)]; 
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

double []MeanColum (int [,]arr)
{
    double [] means = new Double [arr.GetLength(1)];
    for(int j=0; j<arr.GetLength(1); j++)
    {
        for(int i=0; i<arr.GetLength(0); i++)
        {
            means[j] += arr [i,j];
        }
        means[j]=Math.Round(means[j]/arr.GetLength(0),2);
    }
    return means;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}