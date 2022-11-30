while (true)
{
    System.Console.WriteLine("Введите что-нибудь: ");
    string word = Console.ReadLine();
    System.Console.Write("Вы ввели: ");
    System.Console.WriteLine(word);
    if (word == "exit")
    {
        break;
    }
}
System.Console.WriteLine("Всего доброго!!!");
