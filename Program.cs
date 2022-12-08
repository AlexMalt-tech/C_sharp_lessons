// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
               System.Console.Write(matrix[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
}

int rows = RandomNumber(); // Число строк
int collumns = RandomNumber(); // Число столбцов
int[,] table1 = new int[rows, collumns]; // Массив под матрицу
int[,] table2 = new int[rows, collumns];
int[,] result = new int[rows, collumns];

MakeMatrix(table1, rows, collumns); // Создание матрицы
MakeMatrix(table2, rows, collumns); // Создание матрицы
PrintTable(table1, rows, collumns);
System.Console.WriteLine("--------------------");
PrintTable(table2, rows, collumns);

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < collumns; j++)
    {
        result[i, j] = table1[i, j] * table2[i, j];
    }
}
System.Console.WriteLine("Произведение двух матриц:");
PrintTable(result, rows, collumns);