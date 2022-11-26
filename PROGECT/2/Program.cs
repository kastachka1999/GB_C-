/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int M = 8;
int N = 4;
int sum = 0;
int res = Result(N, M);

int Result(int a, int b)
{
    if (a == b)
    {
        return sum += a;
    }
    return sum += a + Result(a + 1, b);
}

Console.WriteLine(res);