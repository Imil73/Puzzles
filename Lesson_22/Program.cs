//Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine( "Выберите пространство для поиска: 2d нажмите 1 , 3d нажмите 2" );
double number = double.Parse( Console.ReadLine() );

if(number == 1)
{
    Console.WriteLine("Задайте координаты X1: ");
    double numberX1 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Y1: ");
    double numberY1 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты X2: ");
    double numberX2 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Y2: ");
    double numberY2 = double.Parse( Console.ReadLine() );

    double res = (numberX1 - numberX2)*(numberX1 - numberX2) + (numberY1 - numberY2) * (numberY1 - numberY2);
    double distance = Math.Sqrt(res);
    Console.WriteLine(distance);
}
if(number ==2)
{

    Console.WriteLine("Задайте координаты X1: ");
    double numberX1 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Y1: ");
    double numberY1 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Z1: ");
    double numberZ1 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты X2: ");
    double numberX2 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Y2: ");
    double numberY2 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Z2: ");
    double numberZ2 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты X3: ");
    double numberX3 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Y3: ");
    double numberY3 = double.Parse( Console.ReadLine() );
    Console.WriteLine("Задайте координаты Z3: ");
    double numberZ3 = double.Parse( Console.ReadLine() );

    double res = (numberX1 - numberX2) * (numberX1 - numberX2) + (numberY1 - numberY2) * (numberY1 - numberY2) + (numberZ1 - numberZ2) * (numberZ1 - numberZ2);
    double distance = Math.Sqrt(res);
    Console.WriteLine(distance);
}
else
{
    Console.WriteLine("Вы ошиблись !");
}





