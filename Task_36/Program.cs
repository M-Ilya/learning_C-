// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Задаём массив чисел
System.Console.WriteLine("Введите количество чисел массива: ");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];

//Заполняем массив случайными числами
for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(-50, 50);
}

//Находим сумму элементов, стоящих на нечётных позициях при помощи метода
int Sum_odd(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}

//Выводим результат
System.Console.WriteLine(string.Join(" : ", array) + " -> " + Sum_odd(array));