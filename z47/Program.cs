// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text) // ввод
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(double[,] array) //функция заполнения массива вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

void PrintMatrix(double[,] matrixPrint) // функция вывода массива в терминал
{
    for (int i = 0; i < matrixPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество столбцов: ");
double[,] matrix = new double[rows, cols];
FillMatrix(matrix);
PrintMatrix(matrix);

