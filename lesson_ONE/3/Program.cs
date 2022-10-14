/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("VVedi chislo");
int a = Convert.ToInt32(Console.ReadLine());

int chetn = a % 2;
Console.WriteLine(chetn);

if (chetn == 0)
{
    Console.WriteLine("chetn");
}
else
{
    Console.WriteLine("ne chetn");
};