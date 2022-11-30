//итоговое задание
void InputArray(string [] array)
{ 
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]+","}");
    }
    Console.WriteLine();
}


void ReleaseArray(string [] array)
{  
    for(int i = 0; i < array.Length; i++)
    {   int j = array[i].Length;
               
        if (j < 4)
        {
           Console.Write($"{array[i] + ","}");
        }
    }
}

Console.Clear();
Console.Write("Введите массив данных: ");
string[] array = Console.ReadLine().Split(' ');
Console.Write("Начальная строка: ");
InputArray(array);
Console.Write("Конечная строка: ");
ReleaseArray(array);
