Console.WriteLine("Введите первое число");

int numberA=int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB=int.Parse (Console.ReadLine());

if (numberA ==numberB*numberB) 
{
  Console.WriteLine("Число А является степенью числа Б");
}
else  Console.WriteLine("Число А не является степенью числа Б");