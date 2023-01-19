﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Решение без использования методов.
// Console.Write("Введите цифру, соответствующую дню недели: \r\n 1-Понедельник \r\n 2-Вторник \r\n 3-Среда \r\n 4-Четверг \r\n 5-Пятница \r\n 6-Суббота \r\n 7-Воскресенье \r\n Необходимый день: ");
// int daynum = Convert.ToInt32(Console.ReadLine());
// if (daynum > 0 && daynum < 6)
//      Console.WriteLine($"День под цифрой {daynum} -> не является выходным");
// else if (daynum == 6 || daynum == 7)
//      Console.WriteLine($"День под цифрой {daynum} -> является выходным");
// else
//     Console.WriteLine($"Введенная цифра ({daynum}) -> не соответствует какому-либо дню недели.");

void DayCheck()
// Решил полностью поместить данную проверку цифры в метод. 
// Надеюсь так разрешено делать, ведь все, что нужно от метода это ввод и проверка числа (на вывод идет только ответ в консоль (Да/Нет)).
{
    Console.Write("Введите цифру, соответствующую дню недели: \r\n 1-Понедельник \r\n 2-Вторник \r\n 3-Среда \r\n 4-Четверг \r\n 5-Пятница \r\n 6-Суббота \r\n 7-Воскресенье \r\n Необходимый день: ");
    int daynum = Convert.ToInt32(Console.ReadLine());
    if (daynum > 0 && daynum < 6)
        Console.WriteLine($"День под цифрой {daynum} -> не является выходным");
    else if (daynum == 6 || daynum == 7)
        Console.WriteLine($"День под цифрой {daynum} -> является выходным");
    else
        Console.WriteLine($"Введенная цифра ({daynum}) -> не соответствует какому-либо дню недели.");
}

DayCheck();
