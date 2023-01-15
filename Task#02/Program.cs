// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение без ввода дополнительных переменных:

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Большее число: ");
    Console.WriteLine(number1);
    Console.Write("Меньшее число: ");
    Console.WriteLine(number2);
}
else if (number1 < number2)
{
    Console.Write("Большее число: ");
    Console.WriteLine(number2);
    Console.Write("Меньшее число: ");
    Console.WriteLine(number1);
}
else
    Console.WriteLine("Введенные числа равны");


// Через дополнительные переменные:

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// int min = 0;
// if (number1 > number2)
// {
//     max = number1;
//     min = number2;
//     Console.Write("Большее число: ");
//     Console.WriteLine(max);
//     Console.Write("Меньшее число: ");
//     Console.WriteLine(min);
// }
// else if (number1 < number2)
// {
//     max = number2;
//     min = number1;
//     Console.Write("Большее число: ");
//     Console.WriteLine(max);
//     Console.Write("Меньшее число: ");
//     Console.WriteLine(min);
// }
// else
//     Console.WriteLine("Введенные числа равны");