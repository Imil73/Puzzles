//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
int numberX = 5;
int numberY = 2;
int revers = -1;

if (revers * (numberX + numberY) == revers * numberX * revers * numberY )
{
    System.Console.WriteLine($"Истинно");
}
else
{
    System.Console.WriteLine($"Неистинно");
}