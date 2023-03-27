//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("N = ");
string N = Console.ReadLine();
int nn = int.Parse(N);
int i = 1;

for (i = 1; i <= nn; i++)
if (i%2 == 0)
{
    Console.WriteLine(i);
}