// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите первое неотрицательное число ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число ");
int n = int.Parse(Console.ReadLine());;
int result = Function_Akkerman(m, n);

Console.Write($"Функция Аккермана = {result} ");

int Function_Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Function_Akkerman(m - 1, 1);
  else return Function_Akkerman(m - 1, Function_Akkerman(m, n - 1));
}
