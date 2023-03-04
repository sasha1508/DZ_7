// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = 8;
int n = 5;

double[,] array = new double[m, n];

// заполнение массива:
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(100); //заполнение ячейки массива целыми числами от 0 до 99
    }
}

// Отображение масива в консоле:
System.Console.WriteLine($"Заполненный массив [{m}, {n}]:");
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        System.Console.Write($"{array[i,j]}\t");
    }
    System.Console.WriteLine();
}

//Находим среднее арифметическое в столбцах:
System.Console.WriteLine();
double sum;
for(int j = 0; j < n; j++)
{
    sum = 0;
    for(int i = 0; i < m; i++)
    {
       sum += array[i, j];
    }
     System.Console.WriteLine($"Среднее арифметическое столбца {j}: {sum / m}");
}
