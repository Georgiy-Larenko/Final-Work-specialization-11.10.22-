
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение элемента массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}

Console.Write("\n" + "Полученный массив: ");
print_array(array);

Console.Write("\n" + "Введите количество символов: ");

int max_word_length = Convert.ToInt32(Console.ReadLine());

Console.Write("\n" + $"Итоговый массив с количеством символов больше, либо равно {max_word_length}: ");

string[] short_array = update_array(array);
print_array(short_array);


// Методы


string[] update_array(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_word_length)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}


void print_array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}
