// Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");

int numberA=int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB=int.Parse (Console.ReadLine());

if (numberA == numberB) 
{
  Console.WriteLine("Первое число равно второму числу");
}
else if (numberA > numberB) 
{
  Console.WriteLine("Первое число большее, а второе меньшее");
}
else  Console.WriteLine("Первое число меньшее, а второе большее");