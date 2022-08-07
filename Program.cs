//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA==numberB)
    Console.WriteLine("Вы ввели равные числа");
if (numberA<numberB)
    Console.WriteLine("Максимальное число: " + numberB + "; минимальное число: " + numberA);
else
    Console.WriteLine("Максимальное число: " + numberA + "; минимальное число: " + numberB);