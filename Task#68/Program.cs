// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction((m -1), AckermannFunction(m, n - 1));
}

Console.Write("Введите неотрицательный параметр m: ");
int mParametr = UserInput();
if (mParametr < 0) IncorrectValue();
Console.Write("Введите неотрицательный параметр n: ");
int nParametr = UserInput();
if (nParametr < 0) IncorrectValue();
int result = AckermannFunction(mParametr, nParametr);
Console.WriteLine($"m = {mParametr}, n = {nParametr} -> A(m,n) = {result}");