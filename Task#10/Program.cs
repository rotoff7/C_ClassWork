// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Я не до конца понял как тут стоит поступать с отрицательными числами (Например: -750).
// Дальше писал решение так, что их нужно было учитывать. Они все же состоят из трех знаков (при условии, что знак "-" не учитывается как 4-ый знак).
// #1. Решение без использования методов.
// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1000 && number > 99 || number > -1000 && number < -99)
// {
//     int answer = Math.Abs((number / 10) % 10);
//     //Добавил Math.Abs чтобы получать положительную вторую цифру у отрицательных чисел (ведь сама цифра должна быть без знака минус)
//     Console.WriteLine($"Вторая цифра числа {number} -> {answer}");
// }
// else
//     Console.WriteLine("Введено не трехзначное число.");


// #2. Решение с использованием методов (проверка числа вне метода).
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SecondDigit(int argument)
{
    int answer = Math.Abs((argument / 10) % 10);
    //Добавил Math.Abs чтобы получать положительную вторую цифру у отрицательных чисел (ведь сама цифра должна быть без знака минус)
    return (answer);
}
if (number < 1000 && number > 99 || number > -1000 && number < -99)
    Console.WriteLine($"Вторая цифра числа {number} -> {SecondDigit(number)}");//Или можно поместить результат в переменную: int answer = SecondDigit(number) и дальше работать с ней.
else
    Console.WriteLine("Введено не трехзначное число.");

// #3. Далее пытался внести проверку числа в метод.
// Основная проблема в том, что я не до конца понимаю как правильно описать ситуацию, когда число не проходит проверку.
// Но что-то рабочее все равно вышло.

// int SecondDigit(int argument)
// {
//     int answer = -1; //(-1) - Некий костыль чтобы метод работал, если ввести число не по формату
//     if (argument < 1000 && argument > 99 || argument > -1000 && argument < -99)
//         {
//         answer = Math.Abs((argument / 10) % 10);
//         Console.Write($"Вторая цифра числа {argument} -> ");
//         }
//     else
//         Console.WriteLine("Введено не трехзначное число.");
//     return (answer);
// }

// Console.Write("Введите трёхзначное число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondDigit(number1));

// // Еще раз

// Console.Write("Введите второе трёхзначное число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondDigit(number2));

// // И еще раз

// Console.Write("Введите третье трёхзначное число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondDigit(number3));