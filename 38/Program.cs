// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*rnd.Next(-1000000,1000000);
    }
return arr;
}
void ArrSee(double[] arr)
{
    Console.Write("[");
    int i=0;
    while (i<arr.Length-1)
    {
        Console.Write($"{arr[i]}|");
        i++;
    }
    Console.Write(arr[i]);
    Console.Write("]");
}
double[] aray= FillArrayWithRandomNumber(Convert.ToInt32(Console.ReadLine()));
ArrSee(aray);
double min = aray[0];
double max =aray[0];
for (int i = 1; i < aray.Length; i++)
{
    if (min>aray[i])
    {
        min=aray[i];
    }
    if (max<aray[i])
    {
        max=aray[i];
    } 
}
Console.WriteLine($" разница иаксимума и минимума {max-min} ");