int a = 3, b = 4, c = 5, d = 6;
System.Console.WriteLine(a++);// 3;    инкремент постфиксный увел-е знач-я на 1 возвр-ся пер-я а затем +1
System.Console.WriteLine(b--);// 4;    декремент постфиксный уменьш-е знач-я на 1 возвр-ся пер-я затем -1
System.Console.WriteLine(a);// 4
System.Console.WriteLine(b);// 3
System.Console.WriteLine(++c);      // инкремент префиксный увел-е знач-я на 1 увеличивается затем возвр-я
System.Console.WriteLine(--d);      // декремент префиксный уменьш-е знач-я на 1 уменьш-ся затем возвр-ся
int x = 10, y = 20, z = 30;
System.Console.WriteLine(x++ * y - z); // 170
x = 10;
System.Console.WriteLine(++x * y); // (x=10+1) * 20 = 220
