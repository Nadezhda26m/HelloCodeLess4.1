// Задаем матрицу/таблицу
// Методы печати и заполнения матрицы

// string[,] table = new string[2,5];
// // String.Empty
// // table[0,0]  table[0,1] ... table[0,4]
// // table[1,0]  table[1,1] ... table[1,4]
// table[1,2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
//     Console.WriteLine();
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++) // вызов количества строк (0)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // вызов количества столбцов (1)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Метод для печати матрицы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для заполнения матрицы
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
