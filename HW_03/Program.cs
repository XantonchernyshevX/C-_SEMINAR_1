// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if(x % 2 == 0)
{
    Console.WriteLine("Число четное");
} 
else
{
    Console.WriteLine("Число нечетное");
}