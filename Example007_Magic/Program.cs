// Получение магического треугольника
// Нахождение середины отрезка
// Цикл
Console.Clear();
int xa = 1, ya = 26,
xb = 40, yb = 1,
xc = 80, yc = 26;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya;
int count = 0;
while (count < 4000) {
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0) {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1) {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}
Console.ReadKey(); // Завершение после нажатия любой клавиши