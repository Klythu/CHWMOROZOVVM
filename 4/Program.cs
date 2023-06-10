Console.WriteLine("введите поочередно 3 числа ");
int[] nums= new int[3];
nums[0] = Convert.ToInt32(Console.ReadLine());
nums[1] = Convert.ToInt32(Console.ReadLine());
nums[2] = Convert.ToInt32(Console.ReadLine());
int max = nums[0];
foreach (int s in nums)
{
    if(max<s)
    {
        max=s;
    }
}
Console.WriteLine($"{max} наибольшее число");