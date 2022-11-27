// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Задаём размеры массива
System.Console.WriteLine("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество колонок массива: ");
int col = Convert.ToInt32(Console.ReadLine());

//вызываем методы
System.Console.WriteLine("Задан массив: ");
PrintArray(GetArray(row, col));

//Метод, создающий и заполняющий массив
int[,] GetArray(int mRow, int nCol)
{
    int[,] result = new int[mRow, nCol];
    int minCount = 1; //начальное значение чисел матрицы
    int loop = 0;           //ярусы заполнения матрицы
    //вычисляем количество ярусов заполнения матрицы  
    if (mRow > nCol)
    {
        loop = nCol / 2 + nCol % 2;
    }
    else loop = mRow / 2 + mRow % 2;
    ////////////////////////////////////////////////////
    for (int l = 0; l < loop; l++)      //цикл ярусов заполнения
    {
        for (int i = l; i < mRow - l; i++)
        {
            for (int j = l; j < nCol - l; j++)
            {
                if (i == l)                                                 //верхняя строка
                {
                    result[i, j] = minCount++;
                }
                if (i == mRow - l - 1 && l != mRow - l - 1)                 //нижняя строка
                {
                    result[i, j] = (minCount++ - j * 2) + nCol - 1;
                }
                if (j == nCol - l - 1 && i != l && i != mRow - l - 1)       //правая колонка
                {
                    result[i, j] = minCount++;
                }
                if (j == l && i != l && i != mRow - l - 1 && j != nCol / 2) //левая колонка
                {
                    result[i, j] = (minCount - 1) + (nCol - 2 * l) + (mRow - i - l - 1) * 2;
                }
            }
        }
        minCount += mRow - (l + 1) * 2; //вычисляем первое число следующего яруса
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