/*Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
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
int FindMinSumRow(int[,] matrix)
{
    int row = 0;
    double minSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i + 1} строки = {Math.Round(sum, 2)}");
    }
    return row + 1;
}
int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
if (rows == columns)
{
    System.Console.WriteLine("Массив не прямоугольный");
    return;
}
int[,] matrix = CreateMatrix(rows, columns);
PrintArray(matrix);
System.Console.WriteLine($"Строка с минимальной суммой{FindMinSumRow(matrix)}");