// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//double[] ReadArr3(string input)
//{
//    double[] array= new double[3];
//    string[] arr= new string[array.Length];
//    int i=0;
//    int j=0;
//    while (i<array.Length)
//   {
//        if (input[j].Equals("."))
 //       {
 //           i++;
 //           j++;
//        }
//        if (input[j].Equals(" "))
//        {
//            j++;
//        }
//        arr[i]=arr[i]+input[j];
//        j++;
//        if (j>=input.Length-1)
//        {
//            break;
//        }
//    }
//    i=0;
//    while(i<array.Length)
//    {
//        array[i]=Convert.ToDouble(arr[i]);
//        i++
//    }
//    return array;
//}

double RealLen(double[] array1,double[] array2)
{
    double sumAndRes=0;
    int i=0;
    while (i<array1.Length)
    {
        sumAndRes=sumAndRes+(array1[i]-array2[i])*(array1[i]-array2[i]);
        if (i==array1.Length-1)
        {
            sumAndRes=Math.Sqrt(sumAndRes);
        }
        i++;
        
    }
    return sumAndRes;
}
Console.WriteLine("введите координаты первого вектора");
double[] arr1= new double[3];
double[] arr2= new double[3];
Console.WriteLine("введите координату X");
arr1[0]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Y");
arr1[1]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Z");
arr1[2]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координаты второго вектора");
Console.WriteLine("введите координату X");
arr2[0]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Y");
arr2[1]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Z");
arr2[2]= Convert.ToDouble(Console.ReadLine());
Console.WriteLine(RealLen(arr1,arr2));
