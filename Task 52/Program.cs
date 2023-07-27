// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAverage(double[,] massive)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            average = average + (massive[j, i] / (massive.GetLength(0)));
        }
        if (i != massive.GetLength(1) - 1) Console.Write($"{(Math.Round(average, 1))}; ");
        else Console.Write($"{(Math.Round(average, 1))}.");
        average = 0;
    }
}

void Print2DMassive(double[,] massive)
{
    Console.WriteLine();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2DMassive(m, n, 0, 9);
Print2DMassive(massive);
GetAverage(massive);