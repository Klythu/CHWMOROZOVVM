// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int InputI(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

int Irendo(int min,int max)
{
    if (min>max)
    {
        Random rand= new Random();
        int res=rand.Next(max,min);
        return res;
    }
    else
    {
        Random rand= new Random();
        int res=rand.Next(min,max);
        return res;
    }
    
}
int[] GenArr(int len,int min, int max )
{
    int[] arr= new int[len];
    int i=0;
    while (i<len)
    {
        
        
        arr[i]+=Irendo(min,max);
        i++;
    }
    return arr;
}
void ArrSee(int[] arr)
{
    Console.Write("[");
    int i=0;
    while (i<arr.Length-1)
    {
        Console.Write($"{arr[i]},");
        i++;
    }
    Console.Write(arr[i]);
    Console.Write("]");
}
string nnn="ggg";
int volum=InputI("длинна масива");
int downnum=InputI("нижняя граница разброса");
int upnum=InputI("верхняя граница разброса");
int[] des= GenArr(volum,downnum,upnum);
ArrSee(des);