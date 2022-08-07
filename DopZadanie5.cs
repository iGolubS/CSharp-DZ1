// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите число N и я покажу все целые числа в промежутке от -N до N: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = -N;
if (N>=0)
{
    while (A<=N)
    {
        Console.WriteLine(A);
        A=A+1;
    }
}
if (N<0)
{
    while (A>=N)
    {
        Console.WriteLine(A);
        A=A-1;
    }
}
