int age = 15;
if (age >= 21)
{
    Console.WriteLine("Доступ разрешен");
}
Console.WriteLine("Программа продолжает работу");

int age1 = 15;
if (age1 >= 18)
{
    Console.WriteLine("Доступ разреен");
}else
{

    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"До совершеннолетия осталось: {18 - age1} года");
}
