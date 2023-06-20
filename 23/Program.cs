// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число");
int num= Convert.ToInt32(Console.ReadLine());
double[] nums = new double[num];
int i = 0;
while (i<nums.Length)
{
    nums[i]=nums[i]+Math.Pow((i+1),3);
    i++;
}
foreach (double s in nums)
{
    Console.WriteLine(s);
}