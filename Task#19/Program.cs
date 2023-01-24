// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение без методов.
// Console.Write("Введите целое число: ");
// int number;
// if (int.TryParse(Console.ReadLine(), out number))
// {
//     int mirrornum = 0;
//     int convertnumber = number;
//     while (convertnumber > 0)
//     {
//         mirrornum = mirrornum * 10 + convertnumber % 10;
//         convertnumber = convertnumber / 10;
//     }
//     if (mirrornum == number)
//         Console.WriteLine($"Число {number} -> является палиндромом");
//     else
//         Console.WriteLine($"Число {number} -> не является палиндромом");
// }
// else
//     Console.WriteLine("Введено некорректное значение. Введите целое число");

// Решение с использованием методов.
int Mirroring(int num)
{
    int mirrornum = 0;
    while (num > 0)
    {
        mirrornum = mirrornum * 10 + num % 10;
        num = num / 10;
    }
    return (mirrornum);
}

void NumberCompare(int num, int mnum)
{
    if (mnum == num)
        Console.WriteLine($"Число {num} -> является палиндромом");
    else
        Console.WriteLine($"Число {num} -> не является палиндромом");
}

Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    NumberCompare(number, Mirroring(number));
else
    Console.WriteLine("Введено некорректное значение. Введите целое число");