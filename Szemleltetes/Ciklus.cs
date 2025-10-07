namespace Szemleltetes;

/// <summary>
/// Ezek csak a többi kód szemléltesését segítik.
/// Nem kell megérteni a működését-használatát.
/// </summary>
public class Ciklus
{
    public static void WriteLine(string szoveg)
    {
        Console.WriteLine(szoveg);
        Console.ReadKey(true);
    }

    public static void Pelda(int sorszam)
    {
        if (sorszam != 1)
        {
            Console.Write("\nA következő példához nyomj meg egy billentyűt...");
            Console.ReadKey(true);
            Console.Clear();
        }
        Console.WriteLine("============== {0}. példa ==============\n", sorszam);
    }

    public static void Write(string szoveg)
    {
        Console.Write(szoveg);
        Thread.Sleep(2);
    }

    public static void Vege()
    {
        Console.WriteLine();
        Console.Write("Példák vége ");
        Console.ReadKey();
    }
}
