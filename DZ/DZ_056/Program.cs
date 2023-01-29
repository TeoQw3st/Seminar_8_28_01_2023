// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandomArray(int line, int column, int start, int end)
{
    int[,] RandomArray = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomArray[i, j] = new Random().Next(start, end + 1);
        }
    }
    return RandomArray;
}

// функиця показа массива
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// функция, котрая находтит строку с минимальной суммой значений
int SearchMinSummInLine(int[,] array)
{
    int minsumm = 0;
    int minline = 0;
    // Console.WriteLine($"минимальная сумма до цикла {minsumm}");

    for (int y = 0; y < 1; y++)
    {

        for (int z = 0; z < array.GetLength(1); z++)
        {
            minsumm = minsumm + array[y, z];
            minline = y+1;
        }

    }
    // Console.WriteLine($"минимальная сумма после первого цикла {minsumm}");
   

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];

        }
        if (summ < minsumm)
        {
            minsumm = summ;
            minline = i + 1;
        }

    }
    // Console.WriteLine($"минимальная сумма после второго цикла {minsumm}");
    // Console.WriteLine($"номер строки с минимальной суммой {minline}");
    return minline;
}



int[,] matr = CreateRandomArray(6, 7, 0, 2);
ShowArray(matr);
Console.WriteLine(SearchMinSummInLine(matr));
// SearchMinSummInLine(matr);