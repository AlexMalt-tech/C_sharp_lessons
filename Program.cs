// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int rowNumber = 3; // Задание строки
int collNumber = 4; // Задание столбца

if(rowNumber < rows & collNumber < collumns)
	System.Console.WriteLine(arr[rowNumber, collNumber]);
else
	System.Console.WriteLine($"{rowNumber}, {collNumber} -> Такого числа нет.");