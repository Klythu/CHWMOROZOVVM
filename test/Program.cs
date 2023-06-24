double[] ReadArr3(string input)
{
    double[] array= new double[3];
    string[] arr= new string[array.Length];
    int i=0;
    int j=0;
    while (i<array.Length)
   {
        if (input[j].Equals("."))
        {
            i++;
            j++;
        }
        if (input[j].Equals(" "))
        {
            j++;
        }
        arr[i]=arr[i]+input[j];
        j++;
        if (j>=input.Length-1)
        {
            break;
        }
    }
    i=0;
    while(i<array.Length)
    {
        array[i]=Convert.ToDouble(arr[i]);
        i++;
    }
    return array;
}
Console.WriteLine("введите координаты первого вектора");
double[] arr1= new double[3];
arr1=ReadArr3(Console.ReadLine());
Console.WriteLine(arr1[0]+1);
Console.WriteLine(arr1[1]+1);
Console.WriteLine(arr1[2]+1);