// Напишите программу, которая на вход принимает число 
// и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");

int nam = Convert.ToInt32(Console.ReadLine());

int result = nam * nam;
Console.WriteLine($"Результат: {result}");

if (nam == result)
{
  Console.Write("Да");
}
else
{
   Console.Write("Нeт");
}