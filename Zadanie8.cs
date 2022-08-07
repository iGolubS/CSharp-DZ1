//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число и я покажу все четные числа от 1 до вашего числа: ");
int N = Convert.ToInt32(Console.ReadLine());
int chet = 1;

if (chet==N||N==0||-chet==N)
{
    Console.WriteLine("Нет четных чисел.");
}
if (N>0)
{
    while (chet<=N)
    {
        while (chet%2==0)
        {
            Console.WriteLine(chet);
            chet = chet + 1;
        }
        chet = chet + 1;
    }
}
if (N<=-0)
{
      while (-chet>=N)
    {
        while (N%2==0)
        {
            Console.WriteLine(N);
            N=N+1;
        }
        N=N+1;
    }  
}