// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 ->78
// 22 3 9 -> 22

// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b) 
// {
// if (a > c){Console.WriteLine($"Максимальное число {a}");}
// else {Console.WriteLine($"Максимальное число {c}");}
// }
// else if (b > c) {Console.WriteLine($"Максимальное число {b}");}
// else Console.WriteLine($"Максимальное число {c}");


// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine($"Максимальное число {max}");


// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число d: ");
// int d = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число e: ");
// int e = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число g: ");
// int g = Convert.ToInt32(Console.ReadLine());
// if (a > b) 
// {
// if (a > c){Console.WriteLine($"Максимальное число {a}");}
// else {Console.WriteLine($"Максимальное число {c}");}
// if (a > d){Console.WriteLine($"Максимальное число {a}");}
// else {Console.WriteLine($"Максимальное число {d}");}
// if (a > e){Console.WriteLine($"Максимальное число {a}");}
// else {Console.WriteLine($"Максимальное число {e}");}
// if (a >g){Console.WriteLine($"Максимальное число {a}");}
// else {Console.WriteLine($"Максимальное число {g}");}
// }
// {if (b > c) {Console.WriteLine($"Максимальное число {b}");}
// else Console.WriteLine($"Максимальное число {c}");
// if (b > d) {Console.WriteLine($"Максимальное число {b}");}
// else Console.WriteLine($"Максимальное число {d}");
// if (b > e) {Console.WriteLine($"Максимальное число {b}");}
// else Console.WriteLine($"Максимальное число {e}");
// if (b > g) {Console.WriteLine($"Максимальное число {b}");}
// else Console.WriteLine($"Максимальное число {g}");
// }
// {if (d > e) {Console.WriteLine($"Максимальное число {d}");}
// else Console.WriteLine($"Максимальное число {e}");
// if (d > g) {Console.WriteLine($"Максимальное число {d}");}
// else Console.WriteLine($"Максимальное число {g}");
// }
// {if (e > g) {Console.WriteLine($"Максимальное число {e}");}
// else Console.WriteLine($"Максимальное число {g}");}

// рабочая программа в итоге
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число d: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число e: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число g: ");
int g = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (g > max) max = g;
Console.WriteLine($"Максимальное число {max}");