//числа от -n до n
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] nums= new int[number*2+1];
int i = 0;
number= -number;
while (i < nums.Length)
{
    nums[i]=nums[i]+number;
    number = number+1;
    i =i+1;
}
foreach (int s in nums) Console.Write($"{s} ");

