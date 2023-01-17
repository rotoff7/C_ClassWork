// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Multiplicity(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
        Console.WriteLine("Число " + arg1 + " кратно " + arg2);
    else
        Console.WriteLine("Число " + arg1 + " не кратно " + arg2 + ", остаток = " + arg1 % arg2);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Multiplicity(num1, num2);


// int Multiplicity(int arg1, int arg2)
// {
//     int result;
//     if (arg1 % arg2 == 0)
//         result = 0;
//     else
//         result = arg1 % arg2;
//     return (result);
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Multiplicity(num1, num2);
