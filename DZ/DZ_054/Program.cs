// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortingArray(int[,] array)
{
    int min = array [0,0];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y=0; y<array.GetLength(1)-1;y++){
            if (array[i,y] < array[i,y+1])
            {
                int temp = array[i,y];
                array[i, y] = array[i,y+1];
                array[i,y+1]=temp;
                
            }
            }

        }
    }
}

int[,] matr = CreateRandomArray(4, 4, 1, 12);
ShowArray(matr);
Console.WriteLine();
SortingArray(matr);
ShowArray(matr);