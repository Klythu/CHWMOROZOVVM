// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double InputD(string msg)
{
    Console.WriteLine(msg);
    double inp=double.Parse(Console.ReadLine());
    return inp;
}

void ArrSee(double[] arr)
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

double[] Cross(double[] line1, double[] line2)
{
    double[] crossdot= new double[2];
    crossdot[0]=(line2[1]-line1[1])/(line1[0]-line2[0]);
    crossdot[1]=crossdot[0]*line1[0]+line1[1];
    return(crossdot);
}

double[] FillLine()
{
    double[] line= new double[2];
    line[0]=InputD("k");
    line[1]=InputD("b");
    return line;
}

ArrSee(Cross(FillLine(),FillLine()));