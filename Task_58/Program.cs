// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Задаём размеры матриц
System.Console.WriteLine("Введите количество строк матрицы А: ");
int rowMatrixA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество колонок матрицы А: ");
int colMatrixA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк матрицы B: ");
int rowMatrixB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество колонок матрицы B: ");
int colMatrixB = Convert.ToInt32(Console.ReadLine());
int minNumber = 0;
int maxNumber = 9;

//Проверим, можно ли эти матрицы перемножить
if (colMatrixA != rowMatrixB)
{
    System.Console.WriteLine("Данные матрицы нельзя перемножить!");
    return;
}
//создаём матрицы
int[,] matrix1 = GetArray(maxNumber, minNumber, rowMatrixA, colMatrixA);
int[,] matrix2 = GetArray(maxNumber, minNumber, rowMatrixB, colMatrixB); ;

//вызываем методы
PrintArray(matrix1, 1);
PrintArray(matrix2, 2);
PrintArray(MultiplicationMatrix(matrix1, matrix2), 3);

//Метод, создающий и заполняющий массив
int[,] GetArray(int max, int min, int mRow, int nCol)
{
    int[,] result = new int[mRow, nCol];
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
void PrintArray(int[,] prArr, int position)
{
    //Задаём разные заголовки для каждой матрицы
    if (position == 1)
    {
        System.Console.WriteLine("Задана матрица A: ");
    }
    if (position == 2)
    {
        if (colMatrixA < 3)
        {
            Console.SetCursorPosition(24, Console.CursorTop - rowMatrixA - 1);
        }
        else
        {
            Console.SetCursorPosition(colMatrixA * 8, Console.CursorTop - rowMatrixA - 1);
        }
        System.Console.WriteLine("Задана матрица B: ");
    }
    if (position == 3)
    {
        System.Console.WriteLine("Произведение матрицы А и В равно: ");
    }
    //Выводим числа матрицы
    for (int i = 0; i < prArr.GetLength(0); i++)
    {
        for (int j = 0; j < prArr.GetLength(1); j++)
        {
            if (position == 1)
            {
                if (j == prArr.GetLength(1) - 1)
                {
                    System.Console.Write(prArr[i, j] + "   |");
                }
                else System.Console.Write(prArr[i, j] + "\t");
            }
            if (position == 2)
            {
                if (j == 0)
                {
                    if (colMatrixA < 3)
                    {
                       Console.SetCursorPosition(Console.CursorLeft + 24, Console.CursorTop);
                    }
                    else
                    {
                        Console.SetCursorPosition(Console.CursorLeft + 8 * colMatrixA, Console.CursorTop);
                    }
                    System.Console.Write(prArr[i, j] + "\t");
                }
                else System.Console.Write(prArr[i, j] + "\t");
            }
            if (position == 3)
            {
                System.Console.Write(prArr[i, j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

//Метод умножения матриц
int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}
