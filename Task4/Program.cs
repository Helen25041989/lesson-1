int number1;
int number2;
int number3;
Console.WriteLine("Введите число №1: ");
number1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №3: ");
number3 = int.Parse(Console.ReadLine());

int[] numbers = { number1, number2, number3 };
Console.WriteLine("Максимальное число:" + numbers.Max());
