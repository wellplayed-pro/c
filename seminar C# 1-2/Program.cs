﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");

int numberA=int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB=int.Parse (Console.ReadLine());

Console.WriteLine("Введите третье число");

int numberC=int.Parse (Console.ReadLine());

int max = numberA;
if (max < numberB)
{
  max = numberB;
}
if (max<numberC)
{
  max = numberC;
}
Console.WriteLine(max);