//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число до которого будут выводиться кубы");
int a=int.Parse (Console.ReadLine());
int i=1;
while (i<=a)
{
  
  Console.Write(Math.Pow(i, 3) + " ");
  i++;
}
