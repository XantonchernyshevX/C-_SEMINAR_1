// Вывести все целые числа от -N до N

Console.Clear();
Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Ряд данных: ");
for (int j = -i; j <= i; j++)
{
    Console.Write($"{j} "); //Console.Write(j+" ");

}