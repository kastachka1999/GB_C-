/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число
 A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Vvedite chislo");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite stepen'");
int b = Convert.ToInt32(Console.ReadLine());

//Math.Pow(a, b)
/*int pow(int x,int n) {
  if (n == 1)
   {
    return x;
  } 
  else
   {
    return x * pow(x, n - 1);
  }
}*/

int pow(int x, int n)
{
    int result = 1;

    for (int i = 0; i < n; i++)
    {
        result *= x;
    }

    return result;
}

Console.WriteLine(pow(a, b));
