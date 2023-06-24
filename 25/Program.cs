//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите основание степени");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите показатель степени");
int power= Convert.ToInt32(Console.ReadLine());
int i=1;
int res =number;
while (i<power)
{
    i++;
    res=res*number;
}
Console.WriteLine(res);