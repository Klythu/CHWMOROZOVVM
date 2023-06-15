// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Hollyday(int num)
{
    if (0>num || num<6)
    {
        Console.WriteLine("нет");
    }
    else if (5>num || num<8)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет такого дня недели");
    }
}
Console.WriteLine("введите номер дня недели");
int num= Convert.ToInt32(Console.ReadLine());
Hollyday(num);
