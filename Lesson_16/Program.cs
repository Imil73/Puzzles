//16. Дано число обозначающее день недели.
// Выяснить является номер дня недели выходным
System.Console.WriteLine( "Введите день недели который вы хотите проверить: " );
int number = int.Parse( Console.ReadLine() );

if(number == 1 ||number == 2 || number == 3 || number == 4 || number == 5)
{
    System.Console.WriteLine( $"Этот день рабочий." );
}
else
{
    if(number == 6 || number ==7 )
    {
        System.Console.WriteLine( $"Этот день выходной." );
    }
    else
    {
        System.Console.WriteLine( $"Error" );
    }
}