// тернарный оператор 
// конструкция  [тип переменная = (условие) ? значение если условие true : значение если условие false]

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string word = num % 2 == 0 ? "this number is even" : "this number is odd";
System.Console.WriteLine(word);





