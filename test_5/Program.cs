string str;                                             // инициализируем тип переменной
double a, b;                                            // инициализируем тип переменной
System.Console.WriteLine("Введите число номер 1:");     // выводим сообщение 
str = Console.ReadLine();                               // считываем первое число и записываем его в str
a = Convert.ToDouble(str);                              // меняем тип str на int
System.Console.WriteLine("Введите число номер 2:");     // запршиваем второе число
str = Console.ReadLine();                               // записываем его в str
b = Convert.ToDouble(str);                              // меняем тип str на int
double result = a + b;                                  // суммируем числа и записываем в result
System.Console.WriteLine("Сумма введенных чисел равна: " + result);  // выводим сообщение и сумму
if (a > b)
{
    System.Console.WriteLine("Частное двух чисел равно: " + a / b);     // если a>b то выводим a/b
}
else
{
    System.Console.WriteLine("Частное двух чисел равно: " + b / a);        // если b>a то b/a
}
