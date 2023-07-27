// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CheckElement(int[,] massive, int rowOfElement, int columnOfElement)
{
    if (massive.GetLength(0) - 1 < rowOfElement | massive.GetLength(1) - 1 < columnOfElement)
        Console.Write($"{rowOfElement}, {columnOfElement} -> такого числа в массиве нет");
    else Console.Write($"{rowOfElement}, {columnOfElement} -> {massive[rowOfElement, columnOfElement]}");
}

void Print2DMassive(int[,] massive)
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

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
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
int rowOfElement = GetInput("Введите cтроку элемента: ");
int columnOfElement = GetInput("Введите cтолбец элемента: ");
int[,] massive = Create2DMassive(m, n, 0, 9);
Print2DMassive(massive);
CheckElement(massive, rowOfElement, columnOfElement);