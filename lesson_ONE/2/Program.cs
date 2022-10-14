/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("VVedi a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("VVedi b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("VVedi c");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"Число {a} больше ");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Число {b} больше");
}
else if (c > a && c > a)
{
    Console.WriteLine($"Число {c} больше");
}
else
{
    Console.WriteLine("Все равны");
};
