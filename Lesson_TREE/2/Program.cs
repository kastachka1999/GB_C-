/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int Read()
{
    return Convert.ToInt32(Console.ReadLine());
}


double[] masA = { 1, 2, 3 };
double[] masB = { 1, 2, 3 };



for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 2; i++)
    {
        if (i == 0)
        {
            Console.WriteLine($"vvedite a{j + 1}");
            masA[j] = Read();
        }
        else
        {
            Console.WriteLine($"vvedite b{j + 1}");
            masB[j] = Read();
        }
    }
}


//не успеваю засунуть в цикл нахождение длинны ,оставлю грубо по формуле (метод рекурсии можно было использовать при нахождении квадрата разницы)

double l = Math.Pow(Math.Pow((masA[0] - masB[0]), 2) + Math.Pow((masA[1] - masB[1]), 2) + Math.Pow((masA[2] - masB[2]), 2), 0.5);
Console.WriteLine(l);



