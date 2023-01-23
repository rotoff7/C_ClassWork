// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeTable(int argument)
{
    int count = 1;
    while (count <= argument)
    {
        int result = (int)Math.Pow(count, 3);
        Console.WriteLine($"|{count,3} | {result,4}|");
        count++;
    }
}

Console.Write("Введите натуральное число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number)) // На случай если введут символ.
{
    if (number >= 1) // Проверка числа на натуральность.
    {
        Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
        CubeTable(number);
    }
    else
        Console.WriteLine("Введено не натуральное число. Пожалуйста, введите натуральное число.");
}
else
Console.WriteLine("Введено не натуральное число. Пожалуйста, введите натуральное число.");