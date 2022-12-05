string name = "Eduard";
System.Console.WriteLine(name);
string secondName = "Latypov";
System.Console.WriteLine(secondName);
string middleName = null;
System.Console.WriteLine(middleName ?? "нет отчества"); // устанавливаем дефолтное значение для переменной 
                                                        // под названием middleName, то есть если в переменной будет какое либо значение, то оно выведется на консоль, если же там будет null то выведется нет отчества!!!
