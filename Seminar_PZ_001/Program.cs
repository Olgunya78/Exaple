// Напишите программу, которая на вход принимает 2 числа и выдает,
// какое число больше, а какое меньше.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.WriteLine($"В ходе сравнения вышло, что {a} больше {b}");
}
else if (b > a)
{
Console.WriteLine($"В ходе сравнения вышло, что {b} больше {a}");
}
