// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number==0)
    Console.WriteLine("Вы ввели 0, оно не может быть ни четным ни не четным");
else
    if (number%2==0)
        Console.WriteLine("Число четное!");
    else
        Console.WriteLine("Число нечетное!");