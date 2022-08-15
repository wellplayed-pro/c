//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string str=Console.ReadLine();
int i = 0;
int sum = 0;
for (i = 0; i < str.Length; i++)
{
 sum = sum + int.Parse(str[i].ToString());
}
Console.WriteLine(sum);
  