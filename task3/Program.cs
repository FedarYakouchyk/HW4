Console.Write("Введите любое число: ");
string? num = Console.ReadLine();
int Num = Convert.ToInt32(Convert.ToString(num));
int sum (int number)
{
    int rez = 0;
    for (int i = 1; i <= num!.Length; i++)
    {
        int ost = Num % 10;
        rez = rez + ost;
        Num = Num / 10;
    }
    return rez;
}
System.Console.WriteLine($"Сумма цифр составляющих число {Num} = {sum(Num)}");