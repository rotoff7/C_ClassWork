// Решение с выводом комментария, на случай если все 3 числа равны. Вариант 1.
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1 > number2)
    max = number1;
else if (number1 < number2)
    max = number2;
else if (number2 == number3)
{
    max = number3;
    Console.WriteLine("Введенные числа равны.");
}
else
    max = number2;
if (number3 > max)
    max = number3;
Console.Write("Максимальное значение -> ");
Console.WriteLine(max);

// Решение с выводом комментария, на случай если все 3 числа равны. Вариант 2.
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max;
// if (number1 == number2)
// {
//     if (number2 == number3)
//     Console.WriteLine("Все введенные числа равны");
// }
// if (number1 > number2)
//     max = number1;
// else
//     max = number2;
// if (number3 > max)
//     max = number3;
// Console.Write("Максимальное значение -> ");
// Console.WriteLine(max);