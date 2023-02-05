/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

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
            matrix[i, j] = rnd.Next(1, 10);
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
    Console.WriteLine();
}

void FindResult(int[,] matrix)
{
    Console.WriteLine("Введите индекс: ");
    int indexOne = Convert.ToInt32(Console.ReadLine());
    int indexTwo = Convert.ToInt32(Console.ReadLine());
    if (indexOne > matrix.GetLength(0) || indexTwo > matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        object result = matrix.GetValue(indexOne, indexTwo);
        Console.WriteLine($" Число в индексе [{indexOne} {indexTwo}] равно {result}");
    }


}


int countOfRows = GetNumber("Введите кол-во строк");
int countOfCollums = GetNumber("Введите кол-во колонок");
int[,] matrix = InitMatrix(countOfRows, countOfCollums);
PrintMatrix(matrix);
FindResult(matrix);


