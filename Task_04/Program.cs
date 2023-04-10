// Вывод последней цифры

Console.Clear();
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());
//Console.Write("Последняя цифра: ");
// Console.WriteLine(i % 10);
if(i >=100 && i <1000)
{
    Console.WriteLine($"Последняя цифра: {i % 10}");
}
else{
    Console.WriteLine("Неверное условие");
}