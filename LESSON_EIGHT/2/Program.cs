/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("ВВедите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] start = new int[rows, colums];

int[] result = new int[colums];
int sum = 0;
int min;
int z = 0;

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


Console.WriteLine("Матрица");
for (int i = 0; i < start.GetLength(0); i++)
{
    for (int j = 0; j < start.GetLength(1); j++)
    {
        Console.Write(start[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Сумма строк");
void CreateSum(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += start[i, j];
            result[i] = sum;
        }
        Console.WriteLine(result[i]);
    }
}

CreateSum(start);

void GetMin(int[] array)
{
    min = array[0];
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Preview(array);
}

GetMin(result);


void Preview(int[] array)
{
    foreach (int el in array)
    {
        if (el == min)
        {
            Console.WriteLine($"У строки {z + 1} наименьшая сумма");
        }
        z++;
    }
}

