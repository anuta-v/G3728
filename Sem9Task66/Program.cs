// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// функция сумма чисел от M до N
int SumNum(int m, int n)
{
    int res = m;
    if (m > n)
        return 0;
    else
    {
        res = m + SumNum(m+1, n);
        return res;
    }
}


int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

int res = numM<numN? SumNum(numM,numN):SumNum(numN,numM);
PrintResult("Сумма элементов от m до n " + res);