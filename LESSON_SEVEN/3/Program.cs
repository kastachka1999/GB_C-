/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] mass = new int[4, 4];
/*
int re(int i, int j)
{
    if (i == 0)
    {
        return i;
    }
    if (j == 0)
    {
        return j;
    }
    return mass[re(i - 1, j), re(i, j - 1)] = new Random().Next(0, 10);

}
*/
double summ = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
        Console.Write(mass[i, j] + " ");
        summ += mass[i, j];
    }
    Console.WriteLine();
    Console.WriteLine("CСреднее:" + summ / mass.GetLength(1));
}

