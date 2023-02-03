// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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

int[,] matr = new int[10, 10];
ShowArray(matr);
Console.WriteLine();
int summ = 1;
int j = 0;
int i = 0;

while (summ <= matr.GetLength(0) * matr.GetLength(1))
{
    matr[i, j] = summ;
    summ++;

    if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
        j++;

    else if (i < j && i + j >= matr.GetLength(0) - 1)
        i++;

    else if (i >= j && i + j > matr.GetLength(1) - 1)
        j--;
    else
        i--;

}



ShowArray(matr);