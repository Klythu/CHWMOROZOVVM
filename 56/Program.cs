// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
while (colums==strings)
{
    colums+=Rand.Next(1,10);
}
int[,] Matrix= new int[strings,colums];
for (int i = 0; i < strings; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Random rand=new Random();
        Matrix[i,j]=rand.Next(0,10);
    }
}
return Matrix;
}

int SmallMString(int[,]Matrix)
{
    int temp=0;
    int sum=0;
    int smoll=0;
    for (int i = 0; i < Matrix.GetLength(1); i++)
    {
        smoll+=Matrix[0,i];
    }
    for (int i = 1; i < Matrix.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            sum+=Matrix[i,j];
        }
        if (sum<smoll)
        {
            temp=i;
            smoll=sum;
        }
    }
    return(temp);
}

int[,] Numbers=MatrixRandom();
MatrixSee(Numbers);
Console.WriteLine($"Summ is minimal in string {SmallMString(Numbers)+1} ");