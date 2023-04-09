// Выдает день недели по заданому числу

string day1 = "Понедельник";
string day2 = "Вторник";
string day3 = "Среда";
string day4 = "Четверг";
string day5 = "Пятница";
string day6 = "Суббота";
string day7 = "Воскресенье";

Console.WriteLine("Введите число: ");
int day = int.Parse(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day1);
}
else if (day == 2)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day2);
}
else if (day == 3)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day3);
}
else if (day == 4)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day4);
}
else if (day == 5)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day5);
}
else if (day == 6)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day6);
}
else if (day == 7)
{
    Console.WriteLine("День недели: ");
    Console.WriteLine(day7);
}
else
{
    Console.WriteLine("Это не день недели. Введите число от 1 до 7");
}