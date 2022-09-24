// Работа с массивами, способ задания массива
// Метод заполнения массива случайными числами
// Метод, который распечатает массив по порядку
// Метод нахождения индекса первого подходящего элемента

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

// Метод нахождения индекса первого подходящего элемента
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если find в массиве не окажется
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // остановит на первом вхождении
        }
        index++;
    }
    return position;
}

// Задали массив из 10 элементов, заполнили и распечатали его
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
// Выведем позицию в массиве заданного числа
// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);
Console.WriteLine(IndexOf(array, 4));
// Если заданного числа в массиве нет, то покажется позиция -1