/*
    Napisz program obliczający sumę n kolejnych liczb nieparzystych.
*/

int number, sum = 0;
Console.Write("Wprowadź n: ");
number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 != 0) sum += i;
}
Console.WriteLine("Suma liczb nieparzystych wynosi: {0}.", sum);