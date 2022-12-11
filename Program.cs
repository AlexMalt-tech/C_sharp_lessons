// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int num1 = 1, num2 = 15;

int SumNum (int num, int stop)
{
	if (num > stop) return 0;
	return num + SumNum(num + 1, stop);
}

System.Console.WriteLine(SumNum(num1, num2));