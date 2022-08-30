// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
int result = Sum(m, n, summa );

if (result ==-5) Console.Write($"M не должно быть больше N ");
else Console.Write ($"Сумма элементов равна = {result} ");

int Sum(int m, int n, int summa)
{
  if (m == n) return summa + m;
  else if (m < n)
  {
    summa = summa + m;
    return Sum(m + 1, n, summa);
  }
  else return -5;
}