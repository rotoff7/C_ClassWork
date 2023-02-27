// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int value)) IncorrectValue();
    return value;
}

int MtoNAllNumbersSum(int num1, int num2)
{
    if (num1 < num2)
        return num1 + MtoNAllNumbersSum(num1 + 1, num2);
    else if (num1 > num2)
        return num2 + MtoNAllNumbersSum(num1, num2 + 1);
    else return num1;
}

Console.Write("Введите первое число: ");
int firstNumber = UserInput();
if (firstNumber <= 0) IncorrectValue();
Console.Write("Введите второе число: ");
int secondNumber = UserInput();
if (secondNumber <= 0) IncorrectValue();
int result = MtoNAllNumbersSum(firstNumber, secondNumber);
Console.WriteLine($"M = {firstNumber}; N = {secondNumber} -> {result}");