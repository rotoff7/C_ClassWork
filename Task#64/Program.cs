// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int value)) IncorrectValue();
    return value;
}

void FromNto1(int number)
{
    if (number > 1) // Если не заморачиваться с выводом ответа как в примере, то number > 0.
    {
        Console.Write($"{number}, ");
        FromNto1(number - 1);
    }
}

Console.Write("Введите натуральное число: ");
int number = UserInput();
if (number <= 0) IncorrectValue();
Console.Write("'");
FromNto1(number);
Console.WriteLine("1'"); // Костыли для вывода ответа как в примере.
