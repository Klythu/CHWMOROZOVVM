Console.WriteLine("введите 1-ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2-ое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.Write("максимальное число ");
    Console.Write(number2);
}
else
{
    Console.Write("максимальное число ");
    Console.Write(number1);
}