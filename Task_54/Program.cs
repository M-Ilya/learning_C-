// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Задаём размеры массива
System.Console.WriteLine("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество колонок массива: ");
int col = Convert.ToInt32(Console.ReadLine());
int minNumber = 0;
int maxNumber = 9;

//создаём двумерный массив
int[,] result = new int[row, col];

//вызываем методы
System.Console.WriteLine("Задан массив: ");
PrintArray(GetArray(maxNumber, minNumber, row, col));
System.Console.WriteLine("В итоге получается вот такой массив: ");
PrintArray(SortArray(result, row, col));

//Метод, создающий и заполняющий массив
int[,] GetArray(int max, int min, int mRow, int nCol)
{
    for (int i = 0; i < mRow; i++)
    {
        for (int j = 0; j < nCol; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

//Метод вывода массива
void PrintArray(int[,] prArr)
{
    for (int i = 0; i < prArr.GetLength(0); i++)
    {
        for (int j = 0; j < prArr.GetLength(1); j++)
        {
            System.Console.Write(prArr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//Метод, сортирующий по убыванию элементы каждой строки
int[,] SortArray(int[,] array, int sortRow, int sortCol)
{
        int temp;
        for (int i = 0; i < sortRow; i++)
        {
             for (int j = 0; j < sortCol - 1; j++)
             {
                 if (array[i, j] < array[i, j + 1])
                 {
                     temp = array[i, j + 1];
                     array[i, j + 1] = array[i, j];
                     array[i, j] = temp;
                     j = -1;
                 }
             }
        }
        return array;
}