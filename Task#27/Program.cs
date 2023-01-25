// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitsNumSum(int num)
{
    int result = 0;
    while ((int)Math.Abs(num) > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return (int)Math.Abs(result);
}

Console.Write("Введите целое число: "); // Исходя из того, что в данной задаче мы работаем именно с целыми числами.
int number;
if (int.TryParse(Console.ReadLine(), out number))
Console.WriteLine($"Сумма цифр в числе {number} -> {DigitsNumSum(number)}");
else Console.WriteLine("Введено некорректное значение. Введите целое число.");
