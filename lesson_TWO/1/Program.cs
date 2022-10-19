/*Напишите программу, которая принимает на вход трёхзначное число и
 на выходе показывает вторую цифру этого числа.
  (Использовать только математические операции, нельзя использовать число как строку по типу number[1])
456 -> 5
782 -> 8
918 -> 1*/

int random = new Random().Next(100, 1000);
int res = Method(random);
Console.WriteLine($"{random} -> {res}");

int Method(int a)
{
    int result = random / 10 - (random / 100) * 10;
    return result;
}
