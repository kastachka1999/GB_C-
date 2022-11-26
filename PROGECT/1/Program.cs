/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int La_natur = new Random().Next(0, 20);
Console.WriteLine(La_natur);

void Recurce(int a)
{
    if (a == 1) Console.Write($"{a}");
    else
    {
        Console.Write($"{a}, ");
        Recurce(a - 1);
    }
}

Recurce(La_natur);