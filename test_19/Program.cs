// int[] myArray = { 1, 2, 3, 4, 5 };
// myArray = myArray.Append(10).ToArray();
// foreach (var item in myArray)
// {
//     System.Console.Write($"{item} ");
// }

int[,] myList = new int[3, 5];      // объявление двумерного массива
int[,] myLst =
{
    {1, 2, 3, 4, 5},
    {6, 7, 8, 9, 10},
    {11, 12, 13, 14, 15}
};

System.Console.WriteLine(myLst.Rank); // myArray.Rank - возвращает вложенность массива то есть мерность

int num1 = myLst.GetLength(0);  // ответ (3) возвращает длину первого уровня массива
int num2 = myLst.GetLength(1);  // ответ (5) возвращает длину второго уровня массива 

foreach (var item in myLst)
{
    System.Console.Write(item + " ");  //перебирает КАЖДЫЙ элемент массива вне зависимости от вложенности
}
System.Console.WriteLine();

for (int i = 0; i < myLst.GetLength(0); i++)  // перебирает элементы первого уровня вложенности
{
    for (int j = 0; j < myLst.GetLength(1); j++)    // перебирает элементы второго уровня вложенности
    {
        System.Console.Write(myLst[i, j] + "\t");
    }
    System.Console.WriteLine();
}

