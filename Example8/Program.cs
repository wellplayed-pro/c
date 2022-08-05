// Программа:
Console.WriteLine("Введите число");
int number=int.Parse (Console.ReadLine());
//if (number>0) number = Math.Pow(number, 2);
if (number > 0)
{
  number *= number;
  Console.WriteLine("Возвели число в квадрат и получили " +number);
}
if (number < 0)
  Console.WriteLine("Число отрицательное");
if (number ==0)
 Console.WriteLine("Введен 0");