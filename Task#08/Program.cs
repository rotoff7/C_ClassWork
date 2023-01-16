﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Задачу выполнял из того, что в условии программа принимает на вход именно натуральное число

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 2;
if (number >= 2) 
// if/else добавил на случай, если будет введено число "1". Поскольку оно тоже является натуральным, но в ответ будет нечего выводить.
// В целом это также решает проблему, если пользователь введет целое, а не натуральное число
{
    Console.WriteLine("Последовательность всех натуральных, четных чисел до числа "+ number+": ");
    while (start <= number)
    {
        Console.Write(start+" ");
        start = start + 2;
    }
}
else
    Console.WriteLine("Натуральных четных чисел в нужном диапазоне нет");
