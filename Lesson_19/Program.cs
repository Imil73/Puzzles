//Определить номер четверти плоскости,
 //в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.WriteLine( "Введите координаты точки X: " );
int numberX = int.Parse( Console.ReadLine() );
System.Console.WriteLine( "Введите координаты точки Y : " );
int numberY = int.Parse( Console.ReadLine() );
if(numberX > 0 && numberY > 0) Console.WriteLine("1 четверть");
if(numberX < 0 && numberY > 0) Console.WriteLine("2 четверть");
if(numberX < 0 && numberY < 0) Console.WriteLine("3 четверть");
if(numberX > 0 && numberY < 0) Console.WriteLine("4 четверть");