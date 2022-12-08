// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int collumns = RandomNumber(); // Число столбцов
int[,] table = new int[rows, collumns]; // Массив под матрицу
int[,] tableReverse = new int[rows, collumns]; // Перевернутый массив
MakeMatrix(table, rows, collumns); // Создание матрицы
PrintTable(table, rows, collumns);
System.Console.WriteLine("--------------");
for(int i = 0; i < rows; i++)
{
    int[] arr = new int[collumns];

    for(int el = 0; el < collumns; el++)
        {
            arr[el] = table[i, el];
        }

    Array.Sort(arr);
    Array.Reverse(arr);  
    for(int el = 0; el < collumns; el++)
        {
            tableReverse[i, el] = arr[el];
        }
}
PrintTable(tableReverse, rows, collumns);




