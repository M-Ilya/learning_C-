// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
System.Console.WriteLine("Наименьшая сумма элементов в: " + MinLine(result, row, col) + " строке");

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

//Метод, выдающий номер строки с наименьшей суммой элементов
int MinLine(int[,] array, int lineRow, int lineCol)
{
    int index = 1;
    int result = int.MaxValue;
    int sumLine = 0;
    for (int i = 0; i < lineRow; i++)
    {
        sumLine = 0;
        for (int j = 0; j < lineCol; j++)
        {
            sumLine += array[i, j];
        } 
        if (result > sumLine)
        {
            result = sumLine;
            index = i + 1;
        }
    }
    return index;
}