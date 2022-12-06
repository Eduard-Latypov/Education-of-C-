int num = int.MaxValue;
//int result = num + 1;   // получим переполнение и откатимся к минимальному значению
// int result = checked(num + 1);   // получим ошибку переполнения
//System.Console.WriteLine(result);

try
{
    int count = checked(num + 1);
    System.Console.WriteLine(count);
}
catch (System.Exception)
{
    System.Console.WriteLine("Ошибка переполнения!");
}