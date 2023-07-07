// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int InputI(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}
int SummOfNumsI(int LeftN,int RightN)
{
    if (LeftN==RightN)
    {
        return(LeftN);
    }
    return(RightN+SummOfNumsI(LeftN, RightN-1));
}

int Num1=InputI("Number");
int Num2=InputI("Number");
if (Num1>Num2)
{
    Console.WriteLine(SummOfNumsI(Num2,Num1));
}
else
{
    Console.WriteLine(SummOfNumsI(Num1,Num2));
}