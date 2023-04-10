// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Clear();
Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double y = double.Parse(Console.ReadLine());

if(x > y)
{
    Console.WriteLine($"Максимальное число: {x}");
    Console.WriteLine($"Минимальное число: {y}");
}
else
{
    Console.WriteLine($"Максимальное число: {y}");
    Console.WriteLine($"Минимальное число: {x}");
}