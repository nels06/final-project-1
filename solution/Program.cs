Console.Write("Введите необходимый текст через пробел: ");
string[] text = Console.ReadLine().Split(' ');

PrintArray(CreateArray(text, CountElements(text)));



int CountElements(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] CreateArray(string[] array, int len)
{
    string[] newArray = new string[len];
    int k = 0;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}


void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("Результат: []");
    }
    else
    {
        Console.Write("Результат: [");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.WriteLine($"\"{array[array.Length - 1]}\"]");
    }
}
