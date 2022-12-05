// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

static double RandomNumber()
{
	Random rnd = new Random();
	return rnd.Next(-10, 11) + Math.Round((double)rnd.NextDouble(), 1);
}

void MakeMatrix(int m, int n)
{
	double[,] matrix = new double[m, n];
	for(int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 4; j++)
		{	
			matrix[i, j] = RandomNumber();
			System.Console.Write($"{matrix[i, j]} ");
			
		}
		System.Console.WriteLine();
	}
}

int rows = 0, columns = 0;
System.Console.Write("Введите число строк: ");
rows = int.Parse(Console.ReadLine());
System.Console.Write("Введите число столбцов: ");
columns = int.Parse(Console.ReadLine());
MakeMatrix(rows, columns);
