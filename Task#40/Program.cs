// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



bool TriangleCheck(int a, int b, int c)
{
   return a < (b + c) && b < (a + c) && c < (a + b);
}

// Console.WriteLine("Введите три стороны треугольника.");
// Console.Write("Введите сторону a: ");
// int a;
// if (int.TryParse(Console.ReadLine(), out a))
// {
//     Console.Write("Введите сторону b: ");
//     int b;
//     if (int.TryParse(Console.ReadLine(), out b))
//     {
//         Console.Write("Введите сторону c: ");
//         int c;
//         if (int.TryParse(Console.ReadLine(), out c))
//         {
//             bool res = TriangleCheck(a, b, c);
//             Console.WriteLine(res ? "Да" : "Нет");
//         }
//         else Console.WriteLine("Введено некорректное значение.");
//     }
//     else Console.WriteLine("Введено некорректное значение.");
// }
// else Console.WriteLine("Введено некорректное значение.");

Console.WriteLine("Введите три стороны треугольника.");
Console.Write("Введите сторону a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool res = TriangleCheck(sideA, sideB, sideC);
Console.WriteLine(res ? "Да" : "Нет");