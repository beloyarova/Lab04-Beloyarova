int age = 15;
if (age >= 21)
{
    Console.WriteLine("Доступ разрешен");
}
Console.WriteLine("Программа продолжает работу");

Console.WriteLine();
int age1 = 15;
if (age1 >= 18)
{
    Console.WriteLine("Доступ разреен");
}
else
{

    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"До совершеннолетия осталось: {18 - age1} года");
}

Console.WriteLine();
int age2 = 25;
if (age2 < 13)
{
    Console.WriteLine("Ребенок");
}
else if (age2 < 18)
{
    Console.WriteLine("Подросток");
}
else if (age2 >= 60)
{
    Console.WriteLine("Пенсионер");
}
else
{
    Console.WriteLine("Взрослый");
}

Console.WriteLine();
int age3 = 16;
double height = 1.4;
bool adult = false;
if (age3 >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
}else if (height < 1.5 && adult == true)
{
    Console.WriteLine("Можно кататься");
}else
{
    Console.WriteLine("Пока нельзя");
}