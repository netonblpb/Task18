// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();
bool table(bool X, bool Y)
{
    return !(X | Y) == !X & !Y;
}

int result = 1;
Console.WriteLine($"X - True \t Y - True \t :{table(true, true)}");
if (!(table(true, true))) result = 0;
Console.WriteLine($"X - True \t Y - False \t :{table(true, false)}");
if (!(table(true, false))) result = 0;
Console.WriteLine($"X - False \t Y - True \t :{table(false, true)}");
if (!(table(false, true))) result = 0;
Console.WriteLine($"X - False \t Y - False \t :{table(false, false)}");
if (!(table(false, false))) result = 0;

if (result == 0) Console.WriteLine($"\nВыражение ложно");
else if (result == 1) Console.WriteLine($"\nВыражение истинно");