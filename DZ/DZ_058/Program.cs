// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Матрицу 1 можно умножить на матрицу 2 только в том случае, если число столбцов матрицы 1 больше или равняется числу строк матрицы 2. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18
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

int[,] MultiplicationArray(int[,] Arrayone, int[,] Arraytwo)
{

    // задаем новый массив и определяем его размерность она будет равна количество строк первого массива и количество столбцов второго массива
    int[,] Newarray = new int[Arrayone.GetLength(0), Arraytwo.GetLength(1)];
    for (int i = 0; i < Arrayone.GetLength(0); i++)
    {
        for (int j = 0; j < Arraytwo.GetLength(1); j++)
        {
            int summ = 0;
            for (int z = 0; z < Arraytwo.GetLength(0); z++)
            {
                summ = summ + Arrayone[i, z] * Arraytwo[z, j];
                Newarray[i, j] = summ;
            }
            
        }
    }

    return Newarray;
    // }
}




int[,] matr1 = CreateRandomArray(4, 2, 0, 2);
ShowArray(matr1);
Console.WriteLine();
int[,] matr2 = CreateRandomArray(2, 3, 1, 3);
ShowArray(matr2);
Console.WriteLine();
if (matr1.GetLength(1) < matr2.GetLength(0))
{
    Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы меньше количества строк второй матрицы");
}
else
{
    int[,] matr3 = MultiplicationArray(matr1, matr2);

    ShowArray(matr3);
}