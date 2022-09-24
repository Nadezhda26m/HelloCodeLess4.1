// Работа с массивами, способ задания массива
// Метод заполнения массива случайными числами
// Метод, который распечатает массив по порядку

// Метод заполнения массива случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Метод, который печатает массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

// Задали массив из 10 элементов, заполнили и распечатали его
int[] array = new int[10];
FillArray(array);
PrintArray(array);