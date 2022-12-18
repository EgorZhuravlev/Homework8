/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] randomArray1 = CreateRandom2DArray1(3, 3);
Print2DArray(randomArray1);

int[,] randomArray2 = CreateRandom2DArray2(3, 3);
Print2DArray(randomArray2);

int[,] resultArray = Composition(randomArray1, randomArray2);
Print2DArray(resultArray);




int[,] Composition(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    result[i, j] += array1[i, n] * array2[n, j];
                }
            }

        }
    return result;
}



int[,] CreateRandom2DArray1(int rows, int columns)
{
    Random random = new Random();
    int[,] array1 = new int[rows, columns];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = random.Next(1, 10);
        }
    }

    return array1;
}

int[,] CreateRandom2DArray2(int rows, int columns)
{
    Random random = new Random();
    int[,] array2 = new int[rows, columns];

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = random.Next(1, 10);
        }
    }

    return array2;
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

