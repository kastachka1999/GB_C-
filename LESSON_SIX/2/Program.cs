/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Conv(string b)
{
    Console.WriteLine($"VVedite {b}");
    string s = Console.ReadLine();
    double i = Convert.ToDouble(s);
    return i;
}

double[,] mass = { { Conv("b1"), Conv("k1") }, { Conv("b2"), Conv("k2") } };

//(b2 - b1) / (k1 - k2)

double x = (mass[1, 0] - mass[0, 0]) / (mass[0, 1] - mass[1, 1]);
//k1 * x + b1
double y = (mass[0, 1] * x) + mass[0, 0];

Console.WriteLine($"точка пересечения M({x};{y})");




