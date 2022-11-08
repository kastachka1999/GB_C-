/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Vvedite chislo");
string number = Convert.ToString(Console.ReadLine());

int result = 0;
Console.WriteLine(number);
foreach (char a in number)
{

    result += a - 48;
}

Console.WriteLine(result);