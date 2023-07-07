// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int InputI(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

string ShowNumbers(int num)
{
    if (num==1)
    {
        return("1");
    }
    if(num<1)
    {
        return("endless cycle");
    }
    return($"{num},{ShowNumbers(num-1)}");
}

Console.WriteLine(ShowNumbers(InputI("number")));
