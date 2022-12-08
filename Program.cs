// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
static int RandomNumber() // Генератор случайных чисел
{
	Random rnd = new Random();
	return rnd.Next(1, 10);
}

int[,] MakeMatrix(int[,] matrix, int m, int n) // Создание матрицы
{
	for(int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{	
			matrix[i, j] = RandomNumber();
		}
	}
	return matrix;
}

void PrintTable(int[,] matrix, int m, int n) //Печать матрицы
{
    for(int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {	
               System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
        }
}

int rows = RandomNumber(); // Число строк
int collumns = rows; // Число столбцов
int[,] table = new int[rows, collumns]; // Массив под матрицу
int[] rowSum = new int[rows];

MakeMatrix(table, rows, collumns); // Создание матрицы
PrintTable(table, rows, collumns);
System.Console.WriteLine("--------------------");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < collumns; j++)
    {
        rowSum[i] += table[i, j];
    }
}

System.Console.WriteLine("Строка с наименьшей суммой элементов: " + Array.IndexOf(rowSum, rowSum.Min()));





