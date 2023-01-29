
int A = inputNumber("Введите размер массива: ");

int inputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число, попробуйте снова");
    }
    return number;
}

int[] randomMas = new int[A];
Random rand = new Random();
for (int i = 0; i < randomMas.Length; i++)
{
    randomMas[i] = rand.Next(0, 1000);
}
System.Console.WriteLine($"[{string.Join(", ", randomMas)}]");
