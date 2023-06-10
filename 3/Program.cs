//перевод числа в день недели
Console.WriteLine("введите число");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("понедельник");
    return;
}
if (day == 2)
{
    Console.WriteLine("вторник");
    return;
}
if (day == 3)
{
    Console.WriteLine("среда");
    return;
}
if (day == 4)
{
    Console.WriteLine("четверг");
    return;
}
if (day == 5)
{
    Console.WriteLine("пятница");
    return;
}
if (day == 6)
{
    Console.WriteLine("суббота");
    return;
}
if (day == 7)
{
    Console.WriteLine("воскресенье");
    return;
}
else 
{
    Console.WriteLine("в неделе 7 дней");
    return;
}