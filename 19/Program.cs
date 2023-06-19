//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


string Callstr()
{
    Console.WriteLine("введите число из 5 цифр");

    string number= Console.ReadLine();
    return number;
}
string num= string.Empty;

while (num.Length!=5)
{
    num=Callstr();
}
bool polin=false;
int i=0;
while (num[i]== num[num.Length-1-i])
{
    if (i==num.Length/2-1)
    {
        
        polin=true;
        break;
    }
   i++;
}

if (polin)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


