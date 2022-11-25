/*
Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateArray(int i, int j, int z)
{
    int[,,] array = new int[i, j, z];
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                array[k, x, y] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void Visible(int[,,] array)//показ матрицы
{
    Console.WriteLine($"Матрица {array}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $" ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}

int[,,] TreD = CreateArray(2, 2, 2);
Visible(TreD);

