// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Задаём размеры массива
int row = 2;
int col = 2;
int arr = 2;
int minNumber = 10;
int maxNumber = 100;

//создаём трёхмерный массив
int[,,] result = new int[row, col, arr];

//вызываем методы
System.Console.WriteLine("Задан массив: ");
PrintArray(GetArray(maxNumber, minNumber, row, col, arr));

//Метод, создающий и заполняющий массив из неповторяющихся двузначных чисел
int[,,] GetArray(int max, int min, int mRow, int nCol, int qArr)
{
    int[,,] result = new int[mRow, nCol, qArr];
    int[] list = new int[mRow * nCol * qArr];
    int temp = 0;
    int count = 0;
    bool repeat = false;
    for (int i = 0; i < mRow; i++)
    {
        for (int j = 0; j < nCol; j++)
        {
            for (int k = 0; k < qArr;)
            {
                temp = new Random().Next(min, max);
                //дальше проверяем числа на повторение
                repeat = false;
                list[count++] = temp;
                for (int a = 0; a < count - 1; a++)
                {
                      if (temp == list[a])
                      {
                        repeat = true;
                        break;
                      }
                }
                if (repeat)
                {
                    count--;
                }
                else 
                {
                    result[i, j ,k] = temp;
                    k++;
                }
            }
        }
    }
    return result;
}

//Метод вывода массива
void PrintArray(int[,,] prArr)
{
    for (int k = 0; k < prArr.GetLength(2); k++)
    {
        for (int i = 0; i < prArr.GetLength(0); i++)
        {
            for (int j = 0; j < prArr.GetLength(1); j++)
            {
                System.Console.Write(prArr[i, j, k] + "("+ i + "," + j + "," + k + ")" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}