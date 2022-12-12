//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double ReadLineInt()//Ввод числа double
{
    double i = double.Parse(Console.ReadLine());
    return i;
}

double [,] MadeArray2(int length,int length1)//Создание двумерного массива double
{
    double [,] array = new double [length,length1];
    return array;
}

double [,] FillArrayInt(double [,] array)//Заполнение двумерного массива
{
    for(int i = 0;  i < array.GetLength(0); i++)
    { for(int y = 0; y < array.GetLength(1); y++)
        array[i,y] = ReadLineInt();
    }
       return array;
}

double [,] array = MadeArray2(2,2);
Console.WriteLine($"Введите координаты точек b1, k1, b2 и k2 через ENTER");
FillArrayInt (array);
if(array[0,1] != array[1,1])
{
double x = (array[1,0] - array[0,0]) / (array[0,1] - array[1,1]);// x = (b2 - b1) / (k1 - k2)
double y = array[0,1] * x + array[0,0]; // y = k1 * x + b1
Console.WriteLine($"Точка пересечения двух прямых находится на координатах x: {x} и у: {y}");
}
else
Console.WriteLine("Данные прямые параллельны и не пересекаются!");




