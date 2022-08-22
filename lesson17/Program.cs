// Упорядочневание данного массива 68321457 (алгоритм сортировки методом выбора).

int[] array = { 6, 8, 3, 2, 1, 4, 5, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// Упорядочевания по возрастанию
void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSortMin(array);

// Упорядочевания по убыванию
void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] > array[maxPosition]) maxPosition = k;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(array);
SelectionSortMax(array);

PrintArray(array);