// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
int InputI(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

int Akerman(int step,int arg)
{
    if (step==0)
    {
        return(arg);
    }
    return(2*Akerman(step-1, arg)+3);
}

Console.WriteLine(Akerman(InputI("number"),InputI("number")));