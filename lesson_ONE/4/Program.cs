/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("VVedi interval");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;
Console.WriteLine("chetnie chisla:");
while (count < (N + 1))
{
    if (N < count && N == count) Console.WriteLine("VVedi  interval ot 1... and more");

    if (count % 2 == 0)
    {
        Console.Write($"{count}" + " ");
    }
    count++;
};