/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

int x = 0;
int y = 0;
int i = 0;
Console.WriteLine("ВВедите строку и столбец элемента");
string str = Console.ReadLine();

if (str.Length == 2)
{


    foreach (char l in str)
    {
        if (i == 0)
        {
            x = Convert.ToInt32(l) - 48;
            i++;
        }
        else
        {
            y = Convert.ToInt32(l) - 48;
            i--;
        }
    }


    int[,] mass = new int[4, 4];



    if ((mass.GetLength(0) - x) >= 1 || (mass.GetLength(1) - y) >= 1)
    {
        Console.WriteLine(mass[x, y]);
    }
    else
    {
        Console.WriteLine("nothing this element in array");
    }
}
else
{
    Console.WriteLine("ВВедите двухзначное число");
}