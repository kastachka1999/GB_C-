/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Vedite chislo v formate 1, 2, 3");
string s = Convert.ToString(Console.ReadLine());

string[] subs = s.Split(", ");

for (int i = 0; i < subs.Length; i++)
{
    if (i == 0)
    {
        Console.Write($"[{subs[i]}, ");
    }
    else if (i == subs.Length - 1)
    {
        Console.Write($"{subs[i]}]");
    }
    else
    {
        Console.Write($"{subs[i]}, ");
    }
}




