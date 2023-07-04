// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] MatrixRandom()
//return matrix with random values
{
Random Rand=new Random();
int strings=0;
strings+=Rand.Next(1,10);
int colums=0;
colums+=Rand.Next(1,10);
int[,] Matrix= new int[strings,colums];
for (int i = 0; i < strings; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Random rand=new Random();
        Matrix[i,j]=rand.Next(-1000000,1000000);
    }
}
return Matrix;
}

void MatrixSee(int[,] Matrix)
//Show Matrix
{
    for (int i  = 0; i < Matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < Matrix.GetLength(1)-1; j++)
        {
            Console.Write($"{Matrix[i,j]}|");
        }
        Console.Write($"{Matrix[i,Matrix.GetLength(1)-1]}]");
    Console.WriteLine(" ");
    }
}

double[,] MatrixITOD(int[,] MatrixITO)
{
    double[,] MatrixTOD=new double[MatrixITO.GetLength(0),MatrixITO.GetLength(1)];
    for (int i = 0; i < MatrixITO.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixITO.GetLength(1); j++)
        {
            MatrixTOD[i,j]= Convert.ToDouble(MatrixITO[i,j]);
        }
    }
    return(MatrixTOD);
}

void ArrSee(double[] arr)
{
    Console.Write("[");
    int i=0;
    while (i<arr.Length-1)
    {
        Console.Write($"{arr[i]}|");
        i++;
    }
    Console.Write(arr[i]);
    Console.Write("]");
}

double[] MeanMatr(double[,] MatrixD)
{
    double[] MeanArr = new double[MatrixD.GetLength(1)];
    for (int i = 0; i < MatrixD.GetLength(1); i++)
    {
        double count=0;
        for (int j = 0; j < MatrixD.GetLength(0); j++)
        {
            count+= MatrixD[j,i];
        }
        MeanArr[i] = count / MatrixD.GetLength(0);
    }
    return(MeanArr);
}

int[,] MatrixI=MatrixRandom();
MatrixSee(MatrixI);
double[,] MatrixDouble=MatrixITOD(MatrixI);
double[] DifArr=MeanMatr(MatrixDouble);
Console.WriteLine("arithmetic mean");
ArrSee(DifArr);

