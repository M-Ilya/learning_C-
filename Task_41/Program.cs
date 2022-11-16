// Задача 41:
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Вводим числа с клавиатуры
System.Console.WriteLine("Введите строку чисел через запятую: ");
string lineNumbers = Console.ReadLine();

//получаем количество положительных элементов и выводим результат
int positiv = GetPositivNumbers(GetArrayString(lineNumbers));
System.Console.WriteLine("Количество чисел больше нуля -> " + positiv);

//Метод, заполняющий массив числами из введенной строки////////////////////
int[] GetArrayString(string inputString)
{
    //найдём количество чисел в строке
    int size = 0;
    //проверка пустой строки
    if (inputString.Length == 0)
    {
        System.Console.WriteLine("Ошибка! Введена пустая строка");
    }
    else //введена не пустая строка
    {
        size++;
        int i = 0;
        while (i < inputString.Length)
        {
            if (inputString[i] == ',')
            {
                size++;
            }
            i++;
        }
    }
    //создадим массив чисел
    int[] array = new int[size];
    //ищем в строке числа и помещяем их в массив
    int j = 0;
    string tempString = string.Empty; //создаём временную пустую строку
    for (int index = 0; index < inputString.Length; index++)
    {
        if (inputString[index] == ' ') //если пробел, то пропускаем
        {
            index++;
        }
        if (inputString[index] != ',') //складываем символы во временную строку
        {
            tempString += inputString[index];
        }
        //когда последний символ или запятая, конвертируем в число
        if (inputString[index] == ',' || index == inputString.Length - 1)
        {
            array[j] = Convert.ToInt32(tempString);
            tempString = string.Empty; //очищаем временную строку после конвертации
            j++;
        }
    }
    return array;
}

//метод, возвращающий количество положительных чисел//////////////////////////////
int GetPositivNumbers(int[] array)
{
    int rezult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            rezult++;
        }
    }
    return rezult;
}
