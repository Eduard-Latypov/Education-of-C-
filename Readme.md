# Мое обучение языку программирования С#

Я начал обучаться данному языку с первой лекции по С# на платформе GeekBrains
то есть 27.11.2022 года! До этого моменты я никогда не сталкивался и не изучал этот язык!
Посмотрим какие будут успехи спустя определенное время!

## Мои успехи в изучении языка в виде списков:

---

1.  Написал программу Hello world!
2.  Написал программу считывающую числа в виде строки с консоли, переводит эти данные в числовой тип данных и производит некие опреции над этими числами
3.  Написал класс и объект внутри которых можно писать программу
4.  Если указать тип переменной, то после уже этот тип поменять нельзы, но можно переназначить значение этой переменной.
5.  Ветвление в С#
6.  Инкремент и декремент, постфиксный и префиксный
7.  Логические операторы && и || то есть and и or.
8.  Создал калькулятор с применением функций switch, case, default.
9.  Добавил цикл while в калькулятор, дабы он мог работать до тех пор, пока пользователь не прекратит его работу.
10. Изучил цикл **do while**, интересная конечно у него работа в отличие от того же самого **while**. Цикл **do while** отличается от классического **while** тем, что **while** сначало проверяет условие, и если условие истинно, то уже после выполняет действие, а **do while** сначало выполняет действие а после уже проверяет условие, даже если условие ложно, то **do while** в любом случае успеет выполнить хоть одно действие!
11. Оказывается существует лайфхак: если набрать "cw" и нажать tab, то автоматически напечатается System.Console.WriteLine что очень сильно упрощает работу с выводом чего-либо на консоль!))
12. Изучил цикл **for**, интересная конечно у него конструкция где в скобках прописывается сразу и старт и конец и шаг, хотя может так и должно быть, я то сравниваю синтаксис с Python.
13. Изучил вариации выполнения цикла **for**, оказывается если убрать все параметры в скобках **for** и оставить только 2 пары точки с запятой, то получится бесконечный цикл. Есть возможность в параметрах указывать не только одну переменную а бесконечное число (правда читаемость такого кода будет никудышней, но это другой вопрос), можно в параметрах также указывать несколько условий остановки цикла используя логические операторы && или ||. Также, если в третьем параметре указать декрмент а не инкремент, то цикл будет выполняться в обратном порядке, правда для этого нужно чтобы переменная была больше нуля (если мы собираемся идти от числа к нулю), и условие пока переменная будет >= нулю.
14. Изучил операторы прерывания и продолжения break и continue. Они используются в циклах (while, do-while, for). Пишится циклы и условие для цикла, если мы не знаем какое количество итераций должен выполнить цикл, то в таком случае удобно использовать оператор break, в связке с каким либо условием, то есть в теле цикла прописывается условие при выполнении которого цикл останавливается! Логика выполнения оператора Continue такая же, как в принципе и в питоне, то есть в теле цикла прописыается условие, при выполнении, которого цикл "перепрыгивает" это (значение, условие) и продолжает дальше свою работу!
15. Вложенные циклы. В принципе ничего сложного, все то же самое, что и в питоне разница только в синтаксисе!
16. Тернарный оператор. Интереснейшая конечно конструкция, в то же время не совсем понятная. Если есть if else, то зачем нужен тернарный оператор? Не понятно! Но тем не менее может в какой-то степени (условно) облегчить написание некоторого скрипта. Конструкция **[тип переменная = условие ? значение : значение_2]** в переменную присваивается значение или значение\*2 в зависимости от условий выполнения условия. Например: **[string word = num % 2 == 0 ? True : False]** - в переменной **word** с типом **string** будет записано **True** если условие **num % 2 == 0** верно или **False** если условие **num % 2 == 0** неверно!
17. Массивы. Небольшое отличие от питона, то есть сначало объявляется массив **int[] myArray;** а после в оперативной памяти, в управляемой куче выделяется память для элементов массива, то на следующей строчке кода указываем сколько элементов будет в массиве **myArray = new int[10]**. Таким образом мы имеем массив с 10 целыми числами то есть нулями по умолчанию. В отличие от динамически типизированных языков коим является Питон, С# строгой типизации, а соответственно массивы содержат исключительно однотипные элементы, то есть если мы объявили массив и указали. что в нем будут только целочисленные элементы, соответственно элементами данного массива будут только целые числа.
18. Взаимодейсвтие с массивами путем применения цикла **for**, заполнение массива, вывод массива поэлементно, взаимодействие с элементами массива (нахождение минимального элемента, сумма четных элементов, вывод массива на печать в обратном порядке)!
19. Списончеы методы. Их, как оказалось довольно много! (Find, Sort, Reverse, FirstOrDefault и т.д.)
20. Cрезы списков. В принципе то же самое, что и в питоне, единственное отличие в питоне срез обозначается двоеточием (:), а в С# срез обозначается двумя точками (..). И последний элемент в списке в C# это (^1), то есть не (-1) как в питоне, а (^1).
