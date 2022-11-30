//итоговое задание
void InputArray(string [] array)
{ Console.Write("Начальная строка: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i < array.Length - 1)
        Console.Write(", ");
    }
    Console.WriteLine();
}


void ReleaseArray(string [] array)
{  Console.Write("Конечная строка: ");
    for(int i = 0; i < array.Length; i++)
    {   int c = array[i].Length;
        int j = 0;
        
        if (c < 4)
        {
            j = i;
            Console.Write($"{array[j]}");
            if(i < array.Length - 1)
            Console.Write(", ");
            
        }
        else Console.Write("");
    }
}

Console.Clear();
Console.Write("Введите массив данных: ");
string[] array = Console.ReadLine().Split(' ');
InputArray(array);
ReleaseArray(array);