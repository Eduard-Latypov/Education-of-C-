int Foo(int num)
{
    if (num % 10 == 0)
        return 0;
    return (num % 10) + Foo(num / 10);
}
int result = Foo(12345);
System.Console.WriteLine(result);
