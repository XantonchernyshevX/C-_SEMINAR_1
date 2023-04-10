// Найти максимальное из трех чисел

Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Максимальное число: "+(Math.Max(x, Math.Max(y, z))));