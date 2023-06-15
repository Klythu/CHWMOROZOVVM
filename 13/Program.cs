// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Hollyday(int num)
{
   num=num/100%10;
   if (num==0)
   {
    Console.WriteLine("нет третьего разряда");
   }
   else
   {
    Console.WriteLine(num);
   }
}
Console.WriteLine("введите число");
int number= Convert.ToInt32(Console.ReadLine());
Hollyday(number);

