/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
ыдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] randomArray = CreateRandom2DArray(5, 3);
Print2DArray(randomArray);
int index = rowNumber(randomArray);
Console.WriteLine($"Строка с наименьшей суммой элементов - {index}");

int[,] CreateRandom2DArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

int rowNumber(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 1)
            {
                sum += array[i,j];
                result += array[i,j];
            }
            else sum += array[i,j];
        }
        if (sum < result)
        {
            result = sum;
            index = i;
        }
        sum = 0;
    }
    return index;
}

void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

