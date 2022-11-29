// Это примитивный калькулятор, который умеет работать только с операторами "+, -, *, /, %".
string command = "да";
while (command == "да" || command == "Да" || command == "ДА" || command == "дА")
{
    System.Console.Clear();
    System.Console.WriteLine("Привет, это примитивный калькулятор.");
    System.Console.WriteLine("Я умею работать только с операторами '+, -, *, /, %'.");
    System.Console.WriteLine("Если хотите работать с дробными числами, воспользуйтесь запятой!");
    System.Console.WriteLine("Введите 1-ый операнд:");
    double x = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второй операнд:");
    double y = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите оператор:");
    string chr = Console.ReadLine();
    switch (chr)
    {
        case "+":
            System.Console.WriteLine(x + " + " + y + " = " + x + y);
            break;
        case "-":
            System.Console.WriteLine(x + " - " + y + " = " + (x - y));
            break;
        case "*":
            System.Console.WriteLine(x + " * " + y + " = " + x * y);
            break;
        case "/":
            if (y == 0)
                System.Console.WriteLine(x + " / " + y + " = " + "0");
            else
                System.Console.WriteLine(x + " / " + y + " = " + x / y);
            break;
        case "%":
            if (y == 0)
                System.Console.WriteLine(x + " % " + y + " = " + "0");
            else
                System.Console.WriteLine(x + " % " + y + " = " + x % y);
            break;
        default:
            System.Console.WriteLine("Вы ввели неизвестный символ.");
            break;
    }
    System.Console.WriteLine("Желаете продолжить?");
    System.Console.WriteLine("да / нет");
    command = Console.ReadLine();
}
System.Console.WriteLine("Всего доброго!!!");
