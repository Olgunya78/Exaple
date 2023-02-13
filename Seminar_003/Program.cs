// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число от 1 до 7: ");
int nam = Convert.ToInt32(Console.ReadLine());
if (nam == 1)
{
  Console.Write("Понедельник ");
}
if (nam == 2)
{
    Console.Write("Вторник");
}
if (nam == 3)
{
    Console.Write("Среда");
}
if (nam == 4)
{
    Console.Write("Четверг");
}
if (nam == 5)
{
    Console.Write("Пятница");
}
if (nam == 6)
{
    Console.Write("Суббота");
}
if (nam == 7)
{
    Console.Write("Воскресение");
}
if (nam > 7)
{
    Console.Write("Ошибка");
}