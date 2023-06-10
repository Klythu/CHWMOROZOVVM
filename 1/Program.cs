// является ли 1-ое число квадратом второго
Console.WriteLine("введите первое число");
int quart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number = Convert.ToInt32(Console.ReadLine());
if (quart == number * number)
{
    Console.WriteLine($"число {quart} является квадратом числа {number}");
}
else
{
    Console.WriteLine($"число {quart} не является квадратом числа {number}");
}