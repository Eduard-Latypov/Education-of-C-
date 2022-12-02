int[] myArray = { 3, 65, 23, 46, 673, 12985, 2, 26, 9, 84, 276, 45632 };
Array.Sort(myArray);                            // списочный метод (сортирует список-аргумент)
for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"{myArray[i]} ");
}
System.Console.WriteLine();

int min = myArray.Min();
int max = myArray.Max();
System.Console.WriteLine(min);      // метод возвращающий минимум в списке
System.Console.WriteLine(max);      // метод возвращающий максимум в списке

Array.Reverse(myArray);             // инвертирует список
for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"{myArray[i]} ");
}
System.Console.WriteLine();
int summa = myArray.Sum();          // списочный метод возвращающий сумму элементов списка
int sum = myArray.Where(i => i % 2 != 0).Sum(); // метод where позволяет принимать в себя делегат
System.Console.WriteLine(summa);                // позволяющий указывать условие для поиска
System.Console.WriteLine(sum);

int min_odd = myArray.Where(i => i % 2 != 0).Min();  // минимум из нечетных чисел 
System.Console.WriteLine(min_odd);

int[] myList = { 5, 34, 1, 1, 2, 4, 5, 2, 87, 56, 4, 2, 87, 5, 98, 56 };
int[] uniq = myList.Distinct().ToArray();   // метод Distinct возвращет только уникальные элементы
for (int i = 0; i < uniq.Length; i++)
{
    System.Console.Write($"{uniq[i]} ");
}
System.Console.WriteLine();

int[] sorted = myList.OrderBy(i => i).ToArray();  // метод сортед как в питоне возвращет отсортированный 
for (int i = 0; i < myList.Length; i++)             // список
{
    System.Console.Write($"{myList[i]} ");
}
System.Console.WriteLine();
for (int i = 0; i < sorted.Length; i++)
{
    System.Console.Write($"{sorted[i]} ");
}
System.Console.WriteLine();

int[] sorted_rev = myList.OrderByDescending(i => i).ToArray();  // возвращает отсортиров-ый список в 
for (int i = 0; i < sorted_rev.Length; i++)                     // обратном порядке для присвоения
{
    System.Console.Write($"{sorted_rev[i]} ");
}
System.Console.WriteLine();

int num = Array.Find(myList, i => i > 35);      // Метод Find принимает в качестве аргументы список где 
System.Console.WriteLine(num);          // нужно произвести поиск и параметр поиска (лямбда). Возвращает
                                        // первое число кторое соответствует параметру поиска

int[] chr = myList.Where(i => i < 5).ToArray();  // возвращает массив чисел удовлетворяющих условию
int charr = myList.Where(i => i < 5).First();    // возвращает первое число удовлетворяющее условию поиска
System.Console.WriteLine(charr);        // если число не найдется то выкинет ошибку

int charrr = myList.Where(i => i < 1).FirstOrDefault();  // вщзвращает первое число удовлетворяющее условию
                                                         // поиска, а если такого числа нету, то вернет дефолтное значение 
                                                         // (0) для int и (Null) для ссылочных типов

int num_2 = Array.FindLast(myList, i => i > 35);  // поиск идет с конца в отличие от предыдущего
System.Console.WriteLine(num_2);

int[] result = Array.FindAll(myList, i => i > 10);// возвращает группу чисел удовлетворяющих условию поиска
for (int i = 0; i < result.Length; i++)             // в виде массива
{
    System.Console.Write($"{result[i]} ");
}
System.Console.WriteLine();

int num_index = Array.FindIndex(myList, i => i == 87);  // возвращает индекс указанного в лямбда числа
System.Console.WriteLine(num_index);        // если указанного числа в массиве нету, метод вернет (-1)

int num_index_last = Array.FindLastIndex(myList, i => i == 87); // собрат предыдущего метода, но поиск 
System.Console.WriteLine(num_index_last);                           // осуществляет с конца
