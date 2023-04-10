// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double z = double.Parse(Console.ReadLine());
Console.Write("Максимальное число: "+(Math.Max(x, Math.Max(y, z))));