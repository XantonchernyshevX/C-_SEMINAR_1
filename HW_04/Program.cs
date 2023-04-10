// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Четные числа: ");
for (int j = 1; j <= i; j++)
{
    if(j % 2 == 0)
    {
        Console.Write($"{j} ");
    } 
}