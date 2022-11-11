/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным значениями элементов массива.

[3 7 22 2 78] -> 76*/
int[] mass = { 1, 2, 3, 4, 5 };

for (int i = 0; i < mass.Length; i++)
{

    mass[i] = new Random().Next(1, 100); ;
    Console.Write($" {mass[i]}");
}
int min = mass[0];
int max = mass[0];


foreach (int el in mass)
{
    if (el < min) min = el;
    if (el > max) max = el;
}
Console.Write($" - min={min} + max={max} res={max - min}");