// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void Multiplicity(int arg1, int arg2)
// {
//     if (arg1 % arg2 == 0)
//         Console.WriteLine("Число " + arg1 + " кратно " + arg2);
//     else
//         Console.WriteLine("Число " + arg1 + " не кратно " + arg2 + ", остаток = " + arg1 % arg2);
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Multiplicity(num1, num2);


// Альтернативный вариант без войд функции и с возвратом переменной.

// int Multiplicity(int arg1, int arg2)
// {
//     int result; // Объявляю переменную для дальнейшей записи результата функции
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

// int globalResult = Multiplicity(num1, num2);

// if (globalResult == 0)
// Console.WriteLine("Число " + num1 + " кратно " + num2);
// else
// Console.WriteLine("Число " + num1 + " не кратно " + num2 + ", остаток = " + globalResult);



// Без условия в функции (В семинаре - основной).

int Multiplicity(int arg1, int arg2)
{
    int result = arg1 % arg2;
    return (result);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int globalResult = Multiplicity(num1, num2);

if (globalResult == 0) // Почему-то считает, что такой переменной не существует
    Console.WriteLine("Число " + num1 + " кратно " + num2);
else
    Console.WriteLine("Число " + num1 + " не кратно " + num2 + ", остаток = " + globalResult);