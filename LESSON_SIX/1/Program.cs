/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
/*Console.WriteLine("Введите числа через пробел");
string values = Console.ReadLine();

string s10 = string.Join(" ", values);
int strong = Convert.ToInt32(s10);
Console.WriteLine(strong);
*/
Console.WriteLine("Введите числа через пробел");
string text = Console.ReadLine();

if (text != "")
{
    string[] words = text.Split(new char[] { ' ' });
    int num = 0;
    int[] mass = new int[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        mass[i] = Convert.ToInt32(words[i]);
    }
    foreach (int i in mass)
    {
        if (i > 0) num++;
    }

    Console.WriteLine("Положительных = " + num);
}
else
{
    Console.WriteLine("введите числа корректно");
}