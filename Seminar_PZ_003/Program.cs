// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).
// 4 ->  да
// -3 ->  нет
// 7 ->  нет

Console.WriteLine("Введите число nam: ");
int nam = Convert.ToInt32(Console.ReadLine());
{if (nam % 2 == 0) {Console.WriteLine($"Число {nam} является чётным");}
else {Console.WriteLine($"Число {nam} является нечётным");}}
