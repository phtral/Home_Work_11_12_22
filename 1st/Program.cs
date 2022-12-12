//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadLineInt() // Ввод числа INT
{
    int i = int.Parse(Console.ReadLine());
    return i;
}

int[] MadeArray(int length) // Создание массива INT
{
    int[] array = new int[length];
    return array;
}

int[] FillArrayInt(int[] array) // Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadLineInt();
    }
    return array;
}

Console.WriteLine($"Введите количество чисел, которые Вы хотите ввести");
int[] array = MadeArray(ReadLineInt());
Console.WriteLine($"Вводите числа по одному через Enter");
FillArrayInt(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sum++;
}

Console.WriteLine($"Количество введенных чисел больше нуля {sum}");




