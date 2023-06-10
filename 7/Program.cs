// последняя цифра числа
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int lastNum = number%10;
Console.WriteLine($"{lastNum} последняя цифра");