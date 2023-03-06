//3. Показать таблицу квадратов чисел от 1 до N 
System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());
int[] array = new int[number];
int quatro = 0;
int cifr = 1;

for (int i = 0; i < number; i++)
{
array[i] = cifr ; cifr += 1;

}
for (int i = 0; i < array.Length; i++)
{  
Console.WriteLine($"{array[i]} * {array[i]} = {array[i] * array[i]}");
}




