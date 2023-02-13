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

int AckermannFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermannFunction(n - 1, 1);
    else return AckermannFunction((n -1), AckermannFunction(n, m - 1));
}

Console.Write("Введите параметр n: ");
int nParametr = UserInput();
Console.Write("Введите параметр m: ");
int mParametr = UserInput();
int result = AckermannFunction(nParametr, mParametr);
Console.WriteLine($"m = {mParametr}, n = {nParametr} -> A(m,n) = {result}");