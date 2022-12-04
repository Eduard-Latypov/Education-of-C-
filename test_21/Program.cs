int[,,] createArray()
{
    int[,,] myArray = new int[new Random().Next(1, 5), new Random().Next(1, 5), new Random().Next(1, 5)];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i, j, k] = new Random().Next(100);
            }
        }
    }
    return myArray;
}

void printArray(int[,,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                System.Console.Write(myArray[i, j, k] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

printArray(createArray());
