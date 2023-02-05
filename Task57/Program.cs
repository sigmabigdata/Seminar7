/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*1. Проверка на число
2.Инициализация массива
3.Печать массива
4.Найти среднее арифметическое элементов в первом  столбце
5 Найти среднее арифметическое в каждом столбце*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int collums)
{
    int[,] matrix = new int[rows, collums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matrix[i, j] = rnd.Next(1, 44);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetMeanNumbersCollums(int[,] matrix)
{
    double sum = 0;
    double mean = 0;
    int count =0;


    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        sum = sum + matrix[i, 0];

    }
    Console.WriteLine($"Среднее арифметическое {sum / matrix.GetLength(0)} ");
    
}

int rows = GetNumber("Введите количество строк: ");
int collums = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, collums);
PrintMatrix(matrix);
GetMeanNumbersCollums(matrix);

