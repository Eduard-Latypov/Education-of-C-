System.Console.WriteLine("Введите диапазон проверки чисел:");
System.Console.WriteLine("Начальная точка:");
int x0 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Конечная точка:");
int y0 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите числа:");
System.Console.WriteLine("Число номер 1:");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine("Число номер 2:");
int y = int.Parse(Console.ReadLine());
if (x >= x0 && y <= y0)                       // **C# (&&) == Python (and), C# (||) == Python (or)!!!**
{
    System.Console.WriteLine("Введенные числа находятся в указанном диапазоне!");
}
else
{
    System.Console.WriteLine("Введенные числа за пределами указанного диапазона!");
}
