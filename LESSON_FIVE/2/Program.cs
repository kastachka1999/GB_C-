/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] mass = { 0, 1, 2, 3, 4, 5 };
int count = 0;
Console.Write("в массиве [");
for (int i = 0; i < mass.Length; i++)
{

    mass[i] = new Random().Next(0, 100); ;
    Console.Write($" {mass[i]}");
    if (i % 2 != 0) count += mass[i];

}
Console.Write($" ]  сумма чисел на нечетных позициях = {count} ({mass[1] + mass[3] + mass[5]})");


