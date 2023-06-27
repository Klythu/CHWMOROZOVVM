// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
Console.WriteLine("number");
int[] ara=FillArrayWithRandomNumber(Convert.ToInt32(Console.ReadLine()));
int count=0;
for (int i = 0; i < ara.Length; i++)
{
    if (ara[i]%2==0)
    {
        count++;
    }
}
ArrSee(ara);
Console.WriteLine($" чётных - {count}");