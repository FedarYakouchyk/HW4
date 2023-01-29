System.Console.Write("Введите число которое нужно возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int Pow(int number)
{
    int rez = A;
    if (B == 0)
    {
        rez = 1;
    }
    if (A == 0 && B == 0)
    {
        rez = 1;
    }
    for (int i = 1; i < B; i++)
    {
        rez = rez * A;
    }
    return rez;
}
int PowA = Pow(A);
System.Console.WriteLine($"Результат возведения: {A}^{B} = {PowA}");