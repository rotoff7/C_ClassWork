// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string quarter = Console.ReadLine()!;
string coord = Coordinates(quarter);
Console.WriteLine(coord);

string Coordinates(string quat)
{
    if (quat == "1") return ("Координаты точек будут в диапазоне X>0, Y>0");
    if (quat == "2") return ("Координаты точек будут в диапазоне X<0, Y>0");
    if (quat == "3") return ("Координаты точек будут в диапазоне X<0, Y<0");
    if (quat == "4") return ("Координаты точек будут в диапазоне X>0, Y<0");
    return ("Четверти с таким номером не существует.");
}