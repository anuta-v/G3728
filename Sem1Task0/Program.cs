// Задача №0
// Напишите програму, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на себя)
// Считываем данные с консоли


String? inputNum = Console.ReadLine();
if(inputNum!=null)

{
  
    int number = int.Parse(inputNum);

    int result = number*number;   

    Console.WriteLine(result);

}

