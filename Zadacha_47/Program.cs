// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int m = 8;
int n = 5;

double[,] array = new double[m, n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble()*200 - 100, 3); //заполнение ячейки массива вещественными числами от -100 до 100
    }
}

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        System.Console.Write($"{array[i,j]};  \t");
    }
    System.Console.WriteLine();
}