// Напишите программу, которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго.
// а = 5; b = 25 ->  да
// а = 2; b = 10 ->  нет
// а = 9; b = -3 ->  нет
// а = -3; b = 9 ->  да

Console.Write("Введите число n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2*n2)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}