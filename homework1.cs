//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string firstnumber = Console.ReadLine();
int first = int.Parse(firstnumber);

Console.WriteLine("Введите второе число: ");
string twonumber = Console.ReadLine();
int two = int.Parse(twonumber);

if (first > two)
{
    Console.Write($"{first} > {two}");
}
else
{
    Console.Write($"{two} > {first}");
}