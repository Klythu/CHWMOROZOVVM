// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число");
int num= Convert.ToInt32(Console.ReadLine());
int[] nums = new int[num];
int i = 0;
while (i<nums.Length)
{
    nums[i]=nums[i]+(1+i)*(1+i)*(1+i);
    i++;
}
foreach (int s in nums)
{
    Console.WriteLine(s);
}