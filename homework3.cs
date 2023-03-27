//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");
string firstnumber = Console.ReadLine();
int first = int.Parse(firstnumber);

if (first%2 == 0)
{
    Console.Write($"Четное");
}
else
{
    Console.Write($"Нечетное");
}