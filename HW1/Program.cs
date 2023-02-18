/*Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива. */
int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
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
int[,] SortRows(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
                if (matrix[rows, j] > matrix[rows, j - 1])
                {
                    int temp = matrix[rows, j];
                    matrix[rows, j] = matrix[rows, j - 1];
                    matrix[rows, j - 1] = temp;
                }
    return matrix;
}
int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] matrix = CreateMatrix(rows, columns);
PrintArray(matrix);
System.Console.WriteLine();
int[,] mtxsortrows = SortRows(matrix);
PrintArray(mtxsortrows);