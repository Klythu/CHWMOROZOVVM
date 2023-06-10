// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
while(number<= 0)
{
    Console.WriteLine("введите положительное число");
    number = Convert.ToInt32(Console.ReadLine());
}
int[] nums= new int[number/2];
int i=0;
while (i< nums.Length)
{
    nums[i]=nums[i]+(i+1)*2;
    i ++;
}
foreach (int s in nums) Console.Write($"{s} ");