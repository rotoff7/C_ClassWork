// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
    Console.WriteLine("Соответствующий номеру день - Понедельник");
else if (number == 2)
    Console.WriteLine("Соответствующий номеру день - Вторник");
else if (number == 3)
    Console.WriteLine("Соответствующий номеру день - Среда");
else if (number == 4)
    Console.WriteLine("Соответствующий номеру день - Четверг");
else if (number == 5)
    Console.WriteLine("Соответствующий номеру день - Пятница");
else if (number == 6)
    Console.WriteLine("Соответствующий номеру день - Суббота");
else if (number == 7)
    Console.WriteLine("Соответствующий номеру день - Воскресенье");
else
    Console.WriteLine("Введено некорректное значение");


// Решение через SwitchCase

//     Console.Write("Введите номер: ");
// int number = Convert.ToInt32(Console.ReadLine());
// switch (number)
// {
//     case 1:
//         Console.WriteLine("Соответствующий номеру день - Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Соответствующий номеру день - Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Соответствующий номеру день - Среда");
//         break;
//     case 4:
//         Console.WriteLine("Соответствующий номеру день - Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Соответствующий номеру день - Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Соответствующий номеру день - Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Соответствующий номеру день - Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Введено некорректное значение");
//         break;
// }