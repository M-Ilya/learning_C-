// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Задаём массив чисел
System.Console.WriteLine("Введите количество чисел массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];

//Заполняем массив случайными трёхзначными числами
for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(100, 1000);
}

//Находим чётные элементы массива при помощи метода
int Search_even(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

//Выводим результат
System.Console.WriteLine(string.Join(" : ", array) + " -> " + Search_even(array));