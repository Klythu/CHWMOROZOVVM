int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
sumPositive += array[i];
}
else
{
sumNegative += array[i];
}
}
System.Console.WriteLine($"Сумма положительных = {sumPositive}, а сумма отрицательных = {sumNegative}");