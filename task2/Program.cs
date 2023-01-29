System.Console.Write("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());

int[] randomMas = new int[A];
Random rand = new Random();
for (int i = 0; i < randomMas.Length; i++)
{
    randomMas[i] = rand.Next(0, 1000);
}
System.Console.WriteLine( string.Join(", ", randomMas));
