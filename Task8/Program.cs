int number;
Console.WriteLine("Введите число N: ");
String stringNum = Console.ReadLine();
number = int.Parse(stringNum);
Console.WriteLine("Четные числа:");
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}