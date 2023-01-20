// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareTable(int argument)
{
    int count = 1;
    while (count <= argument)
    {
        int result = count * count;
        Console.WriteLine($"|{count,3} | {result,4}|");
        count++;
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
SquareTable(number);
else
Console.WriteLine("Введено не натуральное число.");