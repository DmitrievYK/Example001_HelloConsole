Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

// Блок с позицией изначального треугольника - Block with the position of the start triangle
int xa = 40, ya = 1,
xb = 1, yb = 30,
xc = 80, yc = 30;

// Блок кода рисует знаком "+" в консоли конкретную позицию треугольника - The code block draws a specific triangle position in the console with a "+" sign
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // задаем точку и в нее кладем координату 
int count = 0; // счетчик повторений операций - repetition counter
while(count < 10000) // счетчик пока не выполним условие
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2 - случайное чисто, но у нас всего три точки
    if(what == 0) // для первой точки
    {
        x = (x + xa) / 2; // поиск центр отрезка
        y = (y + ya) / 2; // поиск центр отрезка
    }
    if (what == 1) // для второй точки
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) // для третьей точки

    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++; // count += 1; count = count + 1
}