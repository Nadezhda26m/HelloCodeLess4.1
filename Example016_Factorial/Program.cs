// Вычисление факториала числа
// с использованием рекурсии

Console.Clear();
double Factorial(int number) // в int влезают только числа до 16-17!
{
    if (number == 1) return 1;
    else return number * Factorial(number - 1);
}

// Console.WriteLine(Factorial(4));

for (int i = 1; i < 20; i++)
{
    Console.WriteLine(Factorial(i));
}
