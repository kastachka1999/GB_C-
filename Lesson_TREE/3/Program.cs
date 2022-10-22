/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine($"vvedite chislo");
int a = Convert.ToInt32(Console.ReadLine());

while (a == 0) //проверка условия >0
{
    Console.WriteLine($"vvedite chislo bolshe 0");
    a = Convert.ToInt32(Console.ReadLine());
}

for (double i = 1; i < a + 1; i++)
{
    double step = Math.Pow(i, 3);
    Console.Write($"{step} ");
}



