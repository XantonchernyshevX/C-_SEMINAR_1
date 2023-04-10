// Максимальное и минимальное из 2 чисел

Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());

if(x > y)
{
    Console.WriteLine($"Максимальное число: {x}");
    Console.WriteLine($"Минимальное число: {y}");
}
else{
    Console.WriteLine($"Максимальное число: {y}");
    Console.WriteLine($"Минимальное число: {x}");
}