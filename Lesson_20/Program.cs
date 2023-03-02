//20. Задать номер четверти, показать диапазоны для возможных координат
System.Console.WriteLine( "Введите номер четверти: " );
int quarter = int.Parse( Console.ReadLine() );

if(quarter == 1) Console.WriteLine($"X (0 < бесконечность) Y (0 < бесконечность)");
if(quarter == 2) Console.WriteLine($"X (0 > бесконечность) Y (0 < бесконечность)");
if(quarter == 3) Console.WriteLine($"X (0 > бесконечность) Y (0 > бесконечность)");
if(quarter == 4) Console.WriteLine($"X (0 < бесконечность) Y (0 > бесконечность)");




