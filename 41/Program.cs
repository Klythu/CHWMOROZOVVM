// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int InputI(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

int Decider(int size)
{
    int count=0;
    for (int i = 0; i < size; i++)
    {
        int num=InputI("test subject");
        if (num>0)
        {
            count++;
        }
    }
    return(count);
}

int maslen=InputI("write the number of test numbers");
int bignum=Decider(maslen);
Console.WriteLine($"{bignum} number(s) bigger then 0");