// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] MatrixRandom()
//return matrix with random values
{
Random Rand=new Random();
int strings=0;
strings+=Rand.Next(1,100);
int colums=0;
colums+=Rand.Next(1,100);
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

int InputI(string msg)
// write massage and return int input
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

int[] place= new int[2];
int[,] BaseMatrix=MatrixRandom();
place[0]=InputI("string number");
place[1]=InputI("collum number");

if (place[0]>=BaseMatrix.GetLength(0))
{
    if (place[1]>=BaseMatrix.GetLength(1))
    {
        Console.WriteLine("out of range");
    }
}
else
{
    Console.WriteLine(BaseMatrix[place[0],place[1]]);
    Console.WriteLine($"place-{place[0]},{place[1]}");
}
