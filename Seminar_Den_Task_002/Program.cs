// Напишите программу вычисления значения функции возведения числа в квадрат.
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int Power(int x)
{
	return x * x;
}
Console.WriteLine(Power(x));