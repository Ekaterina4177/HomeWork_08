Console.Clear();
Console.Write("Введите номер задачи 54, 56, 58, 60 или 62: ");
int number = int.Parse(Console.ReadLine());

if (number == 54)
{
    FirstTask();
}
else if (number == 56)
{
    TaskSecond();
}
else if (number == 58)
{
    TaskFree();
}
/* else if(number == 60){
    ();
}
else if(number == 62){
    ();
} */
else if (number != 54 || number != 56 || number != 58 ||
        number != 60 || number != 62)
{
    Console.WriteLine("Ошибка. Введите правильный номер задачи.");
}



/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void FirstTask()
{
    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void SortingFromMaxToMin(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int a = 0; a < array.GetLength(1) - j - 1; a++)
                {
                    if (array[i, a] < array[i, a + 1])
                    {
                        int temp = array[i, a];
                        array[i, a] = array[i, a + 1];
                        array[i, a + 1] = temp;
                    }
                }
            }
        }
    }
    int[,] arr = new int[3, 4];
    FillArray(arr);
    Console.WriteLine("Задача 54:Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine();
    Console.WriteLine("Полученный рандомно массив:");
    PrintArray(arr);
    Console.WriteLine();
    SortingFromMaxToMin(arr);
    Console.WriteLine("Отсортированный массив по убыванию:");
    PrintArray(arr);
    Console.WriteLine();
}


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void TaskSecond()
{
    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int SumOfRowElements(int[,] array, int i)
    {
        int sumRow = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        return sumRow;
    }

    void MinSumOfRowElements(int[,] array)
    {
        int minSumRow = 0;
        int sumRow = SumOfRowElements(array, 0);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int tempSumRow = SumOfRowElements(array, i);
            if (sumRow > tempSumRow)
            {
                sumRow = tempSumRow;
                minSumRow = i;
            }
        }
        Console.WriteLine($"Строкa с наименьшей суммой элементов - {minSumRow + 1} ");
    }

    int[,] arr = new int[4, 4];
    FillArray(arr);
    Console.WriteLine("Задача 56:Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine();
    Console.WriteLine("Полученный рандомно массив:");
    PrintArray(arr);
    Console.WriteLine();
    MinSumOfRowElements(arr);
    Console.WriteLine();
}

/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void TaskFree()
{

    void GetMatrix(int[,] matr1, int[,] matr2)
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                matr1[i, j] = new Random().Next(1, 10);
            }
        }
        for (int a = 0; a < matr2.GetLength(0); a++)
        {
            for (int b = 0; b < matr2.GetLength(1); b++)
            {
                matr2[a, b] = new Random().Next(1, 10);
            }
        }
    }
    void PrintMatrix(int[,] matr1, int[,] matr2)
    {
        Console.WriteLine("Первая матрица:");
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                Console.Write($"{matr1[i, j]} ");
            }
            Console.WriteLine();
        }
         Console.WriteLine("Вторая матрица:");
         for (int a = 0; a < matr2.GetLength(0); a++)
         {
             for (int b = 0; b < matr2.GetLength(1); b++)
             {
                 Console.Write($"{matr2[a, b]} ");
             }
             Console.WriteLine();
         }
    }

void TheProductOfTwoMatrices(int[,] matr1, int[,] matr2, int[,] resultMatr)
{
    
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr2.GetLength(0); j++)
        {
            for (int a = 0; a < matr2.GetLength(1); a++){
            sum += matr1[i, a] * matr2[a, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}
void PrintTheProductOfTwoMatrices(int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            Console.Write($"{resultMatr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatr = new int[2, 2];
Console.WriteLine("Задача 58: Найти произведение двух матриц.");
Console.WriteLine();
GetMatrix(matrix1, matrix2);
PrintMatrix(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
TheProductOfTwoMatrices(matrix1, matrix2, resultMatr);
PrintTheProductOfTwoMatrices(resultMatr);
}


