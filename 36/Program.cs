// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999);
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
Console.WriteLine("Length");
int[] ara=FillArrayWithRandomNumber(Convert.ToInt32(Console.ReadLine()));
int count=0;
for (int i = 1; i < ara.Length; i+=2)
{
    count+=ara[i];
}
ArrSee(ara);
Console.WriteLine($"сумма  нечётных позиций - {count}");