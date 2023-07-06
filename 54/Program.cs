// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] MatrixSortString(int[,]IntMatrix)
{
    for (int i = 0; i < IntMatrix.GetLength(0); i++)
    {
        int[]TempArr=new int[IntMatrix.GetLength(1)];
        for (int j = 0; j < IntMatrix.GetLength(1); j++)
        {
            TempArr[j]=IntMatrix[i,j];
        }

        Array.Sort(TempArr);
        for (int j = 0; j < IntMatrix.GetLength(1); j++)
        {
            IntMatrix[i,j]= TempArr[TempArr.Length-1-j];
        }
    }
    return IntMatrix;
}

int[,]Matr=MatrixRandom();
MatrixSee(Matr);
Console.WriteLine("sort");
MatrixSee(MatrixSortString(Matr));