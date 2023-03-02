//15. Дано число. Проверить кратно ли оно 7 и 23
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number %7 == 0 || number %23 == 0) 
{
    System.Console.WriteLine($"Число кратно");
}
else
{
   System.Console.WriteLine($"Число некратно");
} 
