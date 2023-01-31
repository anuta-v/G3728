// Задача №39 
// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на 
// первом месте, а первый - на последнем и т.д.)
// Например: 
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]


int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
    }
}

int[] arr = Gen1DArray(10,0,10);
Print1DArr(arr);
ReverseArray(arr);
Print1DArr(arr);