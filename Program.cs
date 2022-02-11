// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();
bool table(bool X, bool Y)
{
    return !(X | Y) == !X & !Y;
}


Console.WriteLine($"X - True \t Y - True \t :{table(true, true)}");
Console.WriteLine($"X - True \t Y - False \t :{table(true, false)}");
Console.WriteLine($"X - False \t Y - True \t :{table(false, true)}");
Console.WriteLine($"X - False \t Y - False \t :{table(false, false)}");