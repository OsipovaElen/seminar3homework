//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число: ");
string firstnumber = Console.ReadLine();
int first = int.Parse(firstnumber);

Console.WriteLine("Введите второе число: ");
string twonumber = Console.ReadLine();
int two = int.Parse(twonumber);

Console.WriteLine("Введите третье число: ");
string threenumber = Console.ReadLine();
int three = int.Parse(threenumber);
int max = 0;
if (first > two)
{
    max = first;
}
else
{
    max = two;
}
if (three > max)
{
    Console.Write($"{three}");
}
else
{
    Console.Write($"{max}");
}