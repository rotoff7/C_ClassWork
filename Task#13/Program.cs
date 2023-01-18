// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// *В решении находим третью цифру числа от "левого края".

// #1. Решение без использования методов.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numBeforeConvert = number;

// if (number > 99 || number < -99)
// {
// while(number > 999 || number < -999)
// number = number / 10;
// int finalResult = Math.Abs(number % 10);
// Console.WriteLine($"Третья цифры у числа {numBeforeConvert} -> {finalResult}.");
// }
// else
// Console.WriteLine($"У числа {numBeforeConvert} -> третьей цифры нет.");

// #2. Решение с использованием методов. (В методе только нахождение третьего числа)
// int ThirdDigit(int argument)
// {
//     while (argument > 999 || argument < -999)
//         argument = argument / 10;
//     int finalResult = Math.Abs(argument % 10);
//     return (finalResult);
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int answer = ThirdDigit(number);
// if (number > 99 || number < -99)
// Console.WriteLine($"У числа {number} третья цифра -> {answer}");
// else
// Console.WriteLine($"У числа {number} -> третьей цифры нет.");

// #3. Решение где проверка числа тоже внесена в метод. Хоть меня и немного смущает вывод ответа для чисел меньше трех знаков, все равно такой способ нравится больше.
int ThirdDigit(int argument)
{
    int finalResult = -1; // Опять  не знаю что выводить, в случае, когда число не проходит проверку.
    if (argument > 99 || argument < -99)
    {
        Console.Write($"Третья цифры у числа {argument} -> ");
        while (argument > 999 || argument < -999)
            argument = argument / 10;
        finalResult = Math.Abs(argument % 10);
    }
    else
        Console.WriteLine($"У числа {argument} -> третьей цифры нет.");
    return (finalResult);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(number));