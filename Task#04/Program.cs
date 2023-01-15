// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] numbers = new int[3];
int index = 0;
int length = numbers.Length;
int max = 0;
Console.WriteLine("Введите три целых числа: ");
while (index < length)
{
    numbers[index] = Convert.ToInt32(Console.ReadLine());
    if (numbers[index] > max)
        max = numbers[index];
    index++;
}
var massive = string.Join(" ", numbers);
Console.Write("Максимальное из введенных чисел -> ");
Console.WriteLine(max);