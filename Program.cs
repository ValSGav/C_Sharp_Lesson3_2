void Method_1()
{
    Console.WriteLine("Автор это я");
}

void Method_2(string text)
{
    Console.WriteLine($"{text}");
}

void Method_3(string text)
{
    Console.WriteLine($"Количество симоволов в тексте \"{text}\" - {text.Length}");
}

int Method_4()
{
    int numb = new Random().Next(1, 100);
    return numb;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minElementOfSelection = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[minElementOfSelection])
            {
                minElementOfSelection = j;
            }
        }
        int temp = array[i];
        array[i] = array[minElementOfSelection];
        array[minElementOfSelection] = temp;
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

Method_1();
Method_2("Текст параметром");
Method_3("Это текст для подсчета количества символов");
Console.WriteLine($"Случайное число - {Method_4()}");

int[] arr = { 1, 4, 6, 7, 3, 1, 9, 5 };

WriteArray(arr);
SortArray(arr);
Console.WriteLine();
WriteArray(arr);

