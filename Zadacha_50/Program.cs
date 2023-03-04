// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет

Console.Clear();

int m = 8;
int n = 5;

double[,] array = new double[m, n];

// заполнение массива:
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble()*200 - 100, 3); //заполнение ячейки массива вещественными числами от -100 до 100
    }
}

// Отображение масива в консоле:
System.Console.WriteLine($"Заполненный массив [{m}, {n}]:");
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        System.Console.Write($"{array[i,j]};  \t");
    }
    System.Console.WriteLine();
}

//вывод заданного элемента:
System.Console.WriteLine();
System.Console.Write("- Ввведи номер строки: ");
int row = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("- Ввведи номер столбца: ");
int col = Convert.ToInt32(System.Console.ReadLine());

if(row > 0 && row < m && col > 0 && col < n)
{
    System.Console.WriteLine($"- Элемент массива с индексом [{row}; {col}]: {array[row, col]}");
}
else
{
    System.Console.WriteLine("- Такой ячейки в массиве нет");
}
    