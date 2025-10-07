using Szemleltetes;

/* FELADAT - Fibonacci
 * 
 * Számoljuk ki az első 10 Fibonacci számot!
 * https://hu.wikipedia.org/wiki/Fibonacci-számok
 * A  0. Fibonacci szám 0
 * Az 1. Fibonacci szám 1
 * Minden további szám az előző kettő összege.
 */

Ciklus.Pelda(1);

int egyik = 0;
int masik = 1;

Console.WriteLine("0. Fibonacci szám " + egyik);
Console.WriteLine("1. Fibonacci szám " + masik);

// a számlálót indíthatom 2-től, léptetek 9-ig, egyesével növelgetve
for (int i = 2; i < 10; i++)
{
    // kiszámoljuk a következő Fibonacci számot
    int kovetkezo = egyik + masik;
    Console.WriteLine($"{i}. Fibonacci szám {kovetkezo}");

    // ami korábban az "első" volt, helyére kerül a "második"
    egyik = masik;

    // ami korábban a "második" volt, helyére kerül a "következő"
    masik = kovetkezo;
}

/* FELADAT - Egyszerű FizzBuzz
 * 
 * Számoljunk el 1-től 100-ig, és mindig vizsgáljuk meg a számot!
 * Ha osztható 3-mal, írjuk ki: "Fizz".
 * Ha osztható 5-tel, írjuk ki: "Buzz"
 * Ha 3-mal és 5-tel is osztható, mindét szót írjuk ki!
 * Ha egyikkel sem osztható, akkor magát a számot írjuk ki!
 */

Ciklus.Pelda(2);

for (int i = 1; i < 101; i++)
{
    if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

/* FELADAT - Ügyesebb FizzBuzz
 * 
 * Gondoljuk át! Könnyű lenne a játékot bővíteni további szabályokkal?
 * Pl. 7-re "Bang"-et írni, 9-re "Burr"-t, és minden egyéb kombinációt?
 * Próbáljuk átalakítani a kódot! Vezessünk be egy szöveges változót.
 * Az elágazokban ne írjuk ki egyből a választ, csak fűzzük össze!
 */

Ciklus.Pelda(3);

for (int i = 1; i < 101; i++)
{
    string eredmeny = "";

    if (i % 3 == 0)
        eredmeny += "Fizz";

    if (i % 5 == 0)
        eredmeny += "Buzz";

    if (i % 7 == 0)
        eredmeny += "Bang";

    if (i % 9 == 0)
        eredmeny += "Burr";

    if (eredmeny == "")
        eredmeny += i;

    Console.Write(eredmeny + " ");
}

Console.Write("Vége ");
Console.ReadKey();