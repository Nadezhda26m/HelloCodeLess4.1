// Дан массив, нужно его упорядочить от min до max

Console.Clear();
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// Методы
// 1. Метод распечатывания массива
// 2. Метод упорядочивания массива от min до max
// 3. Метод упорядочивания массива от max до min

#region Methods  

// Метод распечатывания массива
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод упорядочивания массива от min до max

void SelectionSortIncrease(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

// Метод упорядочивания массива от max до min

void SelectionSortDecrease(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

#endregion

PrintArray(arr);
SelectionSortIncrease(arr);
PrintArray(arr);
SelectionSortDecrease(arr);
PrintArray(arr);
