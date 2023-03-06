//3. Показать таблицу квадратов чисел от 1 до N 
System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());
int cifr = 1;

for (int i = 0; i < number ; i++)
{  
Console.WriteLine($"{cifr} * {cifr} = {cifr * cifr}");
cifr +=1;
}




