// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число и я покажу вам последнюю цифру этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=0)
{
    if (number<100||number>999)
        Console.WriteLine("Вы ввели не трехзначное число!");
    else
    {
        int rez = number%10;
        Console.WriteLine(rez);
    }
}
if (number<0)
{
    if (number>-100||number<-999)
        Console.WriteLine("Вы ввели не трехзначное число!");
    else
    {
        int rez = number%10;
        Console.WriteLine(-rez);
    }
}