/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void Visible(int[,] array)//показ матрицы
{
    Console.WriteLine($"Матрица {array}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}

int[,] garry = new int[4, 4];


int a = 1;
int i = 0;
int j = 0;

while (a <= garry.Length)
{
    garry[i, j] = a++;
    if (i <= j + 1 && i + j < garry.GetLength(0) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= garry.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > garry.GetLength(0) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

Visible(garry);





