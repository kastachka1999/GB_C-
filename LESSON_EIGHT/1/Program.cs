/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.WriteLine("ВВедите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] start = new int[rows, colums];

int Filling(int i, int j)
{
    for (int k = 0; k <= j; k++)
    {
        start[i, k] = new Random().Next(1, 10);
    }
    if (i == 0) return i;
    return Filling(i - 1, j);

}

Filling(rows - 1, colums - 1);

//int[] random = { 0, 1, 2, 3, 4 };

int min;
void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int x = j + 1; x < array.GetLength(1); x++)
            {
                if (array[i, j] < array[i, x])
                {
                    min = array[i, j];
                    array[i, j] = array[i, x];
                    array[i, x] = min;
                }

            };

        }

    }
}

Console.WriteLine("До");
for (int i = 0; i < start.GetLength(0); i++)
{
    for (int j = 0; j < start.GetLength(1); j++)
    {
        Console.Write(start[i, j] + " ");
    }
    Console.WriteLine();
}

Sort(start);

Console.WriteLine("После");
for (int i = 0; i < start.GetLength(0); i++)
{
    for (int j = 0; j < start.GetLength(1); j++)
    {
        Console.Write(start[i, j] + " ");
    }
    Console.WriteLine();
}

//GetLength(0) string
//GetLength(1) colums
/*
void Big(int[,] array) {
    int max = array 
}

void Reverce(int[,] array) 
{
    for(int i = 1;i <= array.GetLength(0);i++) 
    {

    }
}
*/