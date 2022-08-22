int number1;
int number2;
Console.WriteLine("Введите число №1: ");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
number2 = int.Parse(Console.ReadLine());

int max;
int min;
if (number1 > number2)
{
    max = number1;
    min = number2;
}
else if (number2 > number1)
{
    max = number2;
    min = number1;
}
else
{
    Console.WriteLine("Значения равны");
    return;

}
Console.WriteLine("Максимальное число: " + max + ". Минимальное число: " + min);