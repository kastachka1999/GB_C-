/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/




void Filling(int i, int j, int[,] array)//заполнение
{
    for (int k = 0; k < i; k++)
    {
        for (int x = 0; x <= j - 1; x++)
        {
            array[k, x] = new Random().Next(0, 10);
        }
    }


}

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

void CreateResult(int[,] array, int[,] one, int[,] two)//перемножение
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[i, j] += one[i, k] * two[k, j];
            }
        }
    }
}

Console.WriteLine("ВВедите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows != colums)
{
    Console.WriteLine("ВВедите одинаковое число столбцов и строк");
}
else
{
    int[,] first = new int[rows, colums];
    int[,] second = new int[rows, colums];
    int[,] result = new int[rows, colums];

    Filling(colums, colums, first);
    Visible(first);
    Filling(colums, colums, second);
    Visible(second);
    /*
    (00*00 + 01*10)  (00*01 + 01*11)  
    (10*00 + 11*10)  (10*01 + 11*11)
    */

    CreateResult(result, first, second);
    Visible(result);
}