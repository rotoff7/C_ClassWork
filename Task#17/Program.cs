// 17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string answer = quarter > 0
? $"Выбранным координатам соответствует {quarter} четверти."
: "Введены некорректные координаты.";
Console.WriteLine(answer);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return (1);
    if (x < 0 && yc > 0) return (2);
    if (xc < 0 && yc < 0) return (3);
    if (xc > 0 && yc < 0) return (4);
    return 0;
}