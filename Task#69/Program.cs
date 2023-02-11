// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int Name (int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 * Name(num1, num2 - 1);
}

Console.Write("Введите первое число: ");
int number1 = UserInput();
Console.Write("Введите второе число: ");
int number2 = UserInput();
int result = Name(number1, number2);
Console.WriteLine(result);

