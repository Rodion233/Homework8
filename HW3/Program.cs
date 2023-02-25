/* Задача 3: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц. */

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-15, 75);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] GetMultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i,j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    return resultArray;
}
int rows1 = 3;
int columns1 = 5;
int rows2 = columns1;
int columns2 = 4;
int[,] Array1 = CreateMatrix(rows1, columns1);
int[,] Array2 = CreateMatrix(rows2,columns2);
int[,] result = GetMultArray(Array1,Array2);
System.Console.WriteLine("First matrix");
PrintArray(Array1);
System.Console.WriteLine("Second matrix");
PrintArray(Array2);
System.Console.WriteLine("Result matrix");
PrintArray(result);