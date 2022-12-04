int[][][] createArray()
{
    int[][][] myArray = new int[new Random().Next(2, 6)][][];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new int[new Random().Next(2, 6)][];
        for (int j = 0; j < myArray[i].Length; j++)
        {
            myArray[i][j] = new int[new Random().Next(2, 6)];
            for (int k = 0; k < myArray[i][j].Length; k++)
            {
                myArray[i][j][k] = new Random().Next(100);
            }
        }
    }
    return myArray;
}

void printArray(int[][][] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        for (int j = 0; j < myArray[i].Length; j++)
        {
            for (int k = 0; k < myArray[i][j].Length; k++)
            {
                System.Console.Write(myArray[i][j][k] + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

printArray(createArray());