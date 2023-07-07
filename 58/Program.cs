// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2
void MatrixSee(int[,,] Matrix)
//Show Matrix
{
    for (int i  = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int n = 0; n < Matrix.GetLength(2); n++)
            {
                Console.Write($"{Matrix[i,j,n]}({i}{j}{n})|");
            }
            Console.WriteLine(" ");
        }
        
    
    }
}

int[,,] MatrixRandom()
//return matrix with random values
{
int strings=2;
int depth=2;
int colums=2;

int[,,] Matrix= new int[2,2,2];
for (int i = 0; i < strings; i++)
{
    for (int j = 0; j < colums; j++)
    {
        for (int n = 0; n < depth; n++)
        {
            Random rand=new Random();
            Matrix[i,j,n]=rand.Next(0,10);
        }
    }
}
return Matrix;
}


MatrixSee(MatrixRandom());