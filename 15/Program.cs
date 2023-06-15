// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

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
