int[] myArray = new int[10];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = i + 1;
}

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write(myArray[i] + " ");
}
System.Console.WriteLine();

for (int i = 1; i <= myArray.Length; i++)
{
    System.Console.Write(myArray[myArray.Length - i] + " ");
}
System.Console.WriteLine();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        count += myArray[i];
    }
}
System.Console.WriteLine(count);

int min = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
}
System.Console.WriteLine(min);

