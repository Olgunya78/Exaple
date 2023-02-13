// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> “-4, -3, -2, -1, 0, 1, 2, 3, 4”
// 2 -> “-2, -1, 0, 1, 2”

Console.Write("Please, input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int max = 0;

if (N < 0)
{
  count = N;
  max = -N;
}
else
{
 count = -N;
 max = N; 
}
while(count <= N)
{
  Console.WriteLine(count);
  count +=1;
}
