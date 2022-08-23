//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Ouch(double k1, double b1, double k2, double b2)
{
  double x, y;
  if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
  else if (k1 == k2) Console.WriteLine("Прямые параллельны");
  else
  {
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine("x= " + x +" y= " + y);
  }
}
double k1,k2,b1,b2;
Console.WriteLine("Введите по порядку k1,b1,k2,b2");
k1=double.Parse(Console.ReadLine());
b1=double.Parse(Console.ReadLine());
k2=double.Parse(Console.ReadLine());
b2=double.Parse(Console.ReadLine());
Ouch(k1, b1, k2, b2);