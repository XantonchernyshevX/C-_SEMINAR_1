Console.WriteLine("Введите первое число: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double y = double.Parse(Console.ReadLine());

if(x == Math.Pow(y, 2))
{
    Console.WriteLine("Первое число является квадратом второго");
}

else
{
    Console.WriteLine("Первое число не является квадратом второго");
}