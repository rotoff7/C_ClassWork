// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите числа a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа b: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b)
    Console.WriteLine("Числа b является квадратом числа a");
else
    Console.WriteLine("Числа b не является квадратом числа a");
