// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int PrintLine(int num)
{
	if(num == 0) return 0;
	System.Console.Write(num + ", ");
	return PrintLine(num - 1);
}

int n = 8;
System.Console.Write($"N = {n} -> ");
PrintLine(n);
