//Console.Clear();

//string[,] table = new string[2,5];

//table[1,2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
   // for (int colums = 0; colums < 5; colums++)
   // {
    //    System.Console.WriteLine($"-{table[rows,colums]}-");
    //}
//}


void PrintArray(int[,] matr)
{
for (int i = 0; i <matr.GetLength(0) ; i++)  // можно написать i < matrix.GetLength(0) или вручную писать кол-во строк (3) 
{
    for (int j = 0; j < matr.GetLength(1) ; j++)  // можно написать i < matrix.GetLength(1) или вручную писать кол-во столбцов (4)
    {
        System.Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3,4];

PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
