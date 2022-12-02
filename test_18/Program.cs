int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
System.Console.WriteLine(myArray[^1]);  // [^num] позволяет обращаться к num элементу массива с конца

int[] myArray_2 = myArray[1..7];        // срез списка с 1-го по 7-ой элемент не включительно
for (int i = 0; i < myArray_2.Length; i++)
{
    System.Console.Write($"{myArray_2[i]} ");
}
int[] myArray_3 = myArray[..7];     // рсез списка с нулевого по 7-ой элемент не включительно
