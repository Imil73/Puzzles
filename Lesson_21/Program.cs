 //Программа проверяет пятизначное число на палиндромом.
 System.Console.WriteLine( "Введите число: " );
int number = int.Parse( Console.ReadLine() );
int[] array = new int[5];

for(int i = 0; i < 5; i ++)
{
array[i] = number %10;
number = number / 10;               
}

if(array[0] == array[4] && array[1] == array[3])
 {Console.WriteLine($"Число полиндром");  }
else
{Console.WriteLine($"Число не полиндром");  }