// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void Print(int[] collect)
{
    for(int el = 0; el < collect.Length; el++)
    {
        System.Console.Write($"{collect[el]}, ");
    }
}

int count = 6;
int[] arr = new int[count];
int zero = 0;

for(int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"Ведите {i} число: ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0)
        zero++;
}

Print(arr);
System.Console.WriteLine($" -> {zero}");