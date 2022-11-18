/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int m = Conv("количесво строк");
int n = Conv("количество столбцов");

double[,] mass = new double[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = Math.Round(new Random().NextDouble(), 1) + (new Random().Next(-9, 10));
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

int Conv(string b)
{
    Console.WriteLine($"VVedite {b}");
    string s = Console.ReadLine();
    int i = Convert.ToInt32(s);
    return i;
}