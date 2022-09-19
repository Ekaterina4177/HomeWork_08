Console.Clear();
Console.Write("Введите номер задачи 54, 56, 58, 60 или 62: ");
int number = int.Parse(Console.ReadLine());

if(number == 54){
    FirstTask();
}
/* else if(number == 56){
    ();
}
else if(number == 58){
    ();
}
else if(number == 60){
    ();
}
else if(number == 62){
    ();
} */
else if(number != 54 || number != 56 || number != 58|| 
        number != 60 || number != 62){
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

void FirstTask(){
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


