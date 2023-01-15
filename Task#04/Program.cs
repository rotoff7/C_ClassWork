// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Пришлось немного похимичить с условиями, чтоб все работало и для отрицательных чисел.
// Хотя исходя из примеров задачи, решение только для положительных тоже считалось бы корректным.
// Решение без использования массива
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1 > number2)
    max = number1;
else
    max = number2;
if (number3 > max)
    max = number3;
Console.Write("Максимальное из введенных чисел -> ");
Console.WriteLine(max);


// Решение и использованием массива, но только для положительных чисел 
// Хотя для трех чисел массив не имеет весомого смысла
// int[] numbers = new int[3];
// int length = numbers.Length;
// int max = -1;
// int index = 0;
// Console.WriteLine("Введите три положительных целых числа: ");
// while (index < length)
// {
//     numbers[index] = Convert.ToInt32(Console.ReadLine());
//     if (numbers[index] > max)
//         max = numbers[index];
//     index++;
// }
// Console.Write("Максимальное из введенных чисел -> ");
// Console.WriteLine(max);