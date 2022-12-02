// массивы

int[] myList;                // объявляем массив
myList = new int[10];       //  выделяем в оперативной памяти в управляемой куче память для массива 
myList[0] = 1;              // из 10 элементов
myList[1] = 2;
myList[2] = 3;
System.Console.WriteLine(myList[2]);
System.Console.WriteLine(myList[9]);

int[] myArray = new int[5];         // объявляем массив на 5 элементов заполненный нулями
int[] myArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };  // объявляем массив целых чисел и сразу заполняем его
int[] myLst = new[] { 1, 2, 3, 4 };
int[] MYarray = { 10, 20, 30, 40, 50, 60, 70 };
int[] spisok = Enumerable.Repeat(7, 10).ToArray();  // {7, 7, 7, 7, 7, 7, 7, 7, 7, 7} 7*10
int[] spisok_2 = Enumerable.Range(5, 8).ToArray();  // {5, 6, 7, 8, 9, 10, 11, 12} 8 элементов, счет от 5
System.Console.WriteLine(myArray[3]);
System.Console.WriteLine(myArr[2]);
System.Console.WriteLine(myLst[1]);
System.Console.WriteLine(MYarray[5]);
System.Console.WriteLine(spisok[5]);
System.Console.WriteLine(spisok_2[7]);


