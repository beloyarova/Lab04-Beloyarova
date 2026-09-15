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
}
else if (height < 1.5 && adult == true)
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}

Console.WriteLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Числе нечетное");
}

Console.WriteLine();
Console.Write("Введите вашу оценку: ");
int ball = int.Parse(Console.ReadLine());

if (ball == 2)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (ball == 3)
{
    Console.WriteLine("Удовлетворительно");
}
else if (ball == 4)
{
    Console.WriteLine("Хорошо");
}
else
{
    Console.WriteLine("Отлично");
}

Console.WriteLine();
Console.WriteLine("Вариант 6");
Console.WriteLine();

Console.Write("Введите количество баллов: ");
double point = double.Parse(Console.ReadLine());

if (point < 0 || point > 100)
{
    Console.WriteLine("Неверное значение");
}else if (point >= 90)
{
    Console.WriteLine("Отличтно");
}else if (point >= 75)
{
    Console.WriteLine("Хорошо");
}else if (point >= 60)
{
    Console.WriteLine("Удовлетворитель");
}else
{
    Console.WriteLine("Неудовлетворительно");
}