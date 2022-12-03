int[][] myArray = new int[5][];
myArray[0] = new int[4];
myArray[1] = new int[5];
myArray[2] = new int[6];
myArray[3] = new int[7];
myArray[4] = new int[8];

for (int i = 0; i < myArray.Length; i++)
{
    for (int j = 0; j < myArray[i].Length; j++)
    {
        myArray[i][j] = new Random().Next(1, 100);
        System.Console.Write(myArray[i][j] + "\t");
    }
    System.Console.WriteLine();
}