// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

static int RandomNumber()
{
	Random rnd = new Random();
	return rnd.Next(0, 10);
}

int[,] MakeMatrix(int[,] matrix, int m, int n)
{
	
	for(int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{	
			matrix[i, j] = RandomNumber();
			System.Console.Write($"{matrix[i, j]} ");
		}
		System.Console.WriteLine();
	}
	return matrix;
}

int rows = RandomNumber();
int collumns = RandomNumber();
int[,] arr = new int[rows, collumns];
MakeMatrix(arr, rows, collumns); // Создание матрицы

System.Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < collumns; j++)
{
	int sum = 0;
	for(int i = 0; i < rows; i++)
	{
		sum +=arr[i, j];
	}
	double average = (sum/rows);
	System.Console.Write($" {average};");
}