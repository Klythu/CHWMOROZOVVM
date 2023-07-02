// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Hello, World!");

int InputI(string msg)
// write massage and return int input
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

double[,] MatrixRandom(int colums, int strings)
//return matrix with random values
{
double[,] Matrix= new double[strings,colums];
for (int i = 0; i < strings; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Random rand=new Random();
        Matrix[i,j]=rand.NextDouble()*rand.Next(-1000000,1000000);
    }
}
return Matrix;
}

void MatrixSee(double[,] Matrix)
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

int StrNumber=InputI("Number of strings");
int ColNumber=InputI("Number of colums");
double[,] Matr= MatrixRandom(StrNumber,ColNumber);
MatrixSee(Matr);
