// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
int[] arr = StringToArr(Console.ReadLine());
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество чисел больше 0: {sum}");


// Метод преобразования строки чисел в массив
int[] StringToArr(string input)
{
    int[] arr = new int [input.Length];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        arr[index] = Convert.ToInt32(temp);
        index++;
    }
    return arr;
}





// 2 вариант решения
// Console.Write("Введите числа через пробел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);// Преобразование строки чисел, введенных польхователем, в массив
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Количество чисел больше 0: {count}");

