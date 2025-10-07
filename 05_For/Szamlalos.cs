using Szemleltetes;

/* ISMÉTLÉS */

// A 'while' bármilyen problémára alkalmas, ahol utasítást kell ismételni.
// De leginkább akkor hasznos, ha _nem_ tudjuk, hogy meddig tart a ciklus.
// Esetleg épp arra vagyunk kíváncsiak, hogy mennyi alkalom után állt le.

Ciklus.Pelda(1);

// Mi a helyzet, ha valamiért pontosan tudjuk, hányszor fog lefutni?
// Például írjuk ki parancssorra az első 10 nem negatív egész számot.

int aktualisSzam = 0;
int futamokSzama = 10;

Ciklus.WriteLine("WHILE indul");

// bekerülési feltétel
while (aktualisSzam < futamokSzama)
{
    // utasítások
    Ciklus.WriteLine($"  {aktualisSzam}. futam");

    // számáló léptetése
    aktualisSzam++;
}

Ciklus.WriteLine("WHILE leáll");
Ciklus.WriteLine(" Ennyi futam volt megadva: " + futamokSzama);
Ciklus.WriteLine(" A számláló pedig itt áll: " + aktualisSzam);

// Az aktuális érték pont ugyanott áll, mint a futamok száma!
// Nyilván, hiszen mi állítottuk be, hogy mennyiszer fusson le.

/* FOR CIKLUS 
 * 
 * " számolj el ( innetől ; ideáig ; hányasával ) "
 *
 * Amikor olyan jellegű feladattal találkozunk, hogy valamit 
 * _pontosan_ az adott számú alkalommal akarunk végrehatjani, 
 * és a végén nincs szükség számlálóra (hiszen mi állítjuk be), 
 * akkor 'while' helyett praktikusabb a 'for' ciklus használata.
 *
 * A 'for' kulcsszót egy zárójelpár követi. 
 * Három lépést adnunk meg ;-vel elválasztva:
 *
 *      for 
 *      (
 *          számáló bevezetése; 
 *          feltétel vizsgálata; 
 *          számáló léptetése
 *      )
 *      {
 *           // utasítások
 *      }
 *
 * Tömörebben írva
 *
 *      for ( számálóBevezetés ; feltételVizsgálat ; számálóLéptetés )
 *      {
 *          // utasítások
 *      }
 * 
 * Ezeket ilyen sorrendben, és ennyiszer hajtja majd végre a kód:
 * - a számáló egyszer kerül bevezetésre, a ciklus indulása előtt
 * - a feltételvizsgálat minden futam előtt történik (előtesztelős)
 * - a számáló léptetését mindig csak a futam után végezzük el
 */

Ciklus.Pelda(2);

Ciklus.WriteLine("FOR indul");

for (int szamlalo = 1; szamlalo < 10; szamlalo++)
{
    Ciklus.WriteLine($"  {szamlalo}. futam");
}

Ciklus.WriteLine("FOR leáll");

/* A SZÁMLÁLÓ
 * 
 * Hasonlítsuk össze a kettőt! Vegyük észre, hogy a működésük hasonló!
 * A 'for' ciklus egy tömörebb alak arra, ha a számláló később nem kell.
 *
 * A számláló változót "iterátornak" is nevezzük.
 * Hagyományosan az 'i' nevet szokás neki adni
 */

Ciklus.Pelda(3);

// Mindig használjuk az automatikus kódkiegészítőt: for + tab + tab
// Majd az egyes lépések között újabb tab lenyomásokkal ugrálhatunk.

// Ujjgyakorlat - Próbáljuk ki!
// for tab tab
// j tab
// 10 tab

for (int j = 0; j < 10; j++)
{

}

// Ilyenkor a 'j' egy ún. lokális változó lesz a cikluson belül.
// Később nem tudjuk használni. A kódblokk végén megszűnik létezni!
// Vegyük ki a megjegyzésjeleket, és nézzük meg a hibaüzenetet!
// "Error CS0103 The name 'i' does not exist in the current context"

// Console.WriteLine("A számáló itt áll " + j);

// Ez kifejezetten praktikus! A következő for() ciklusnál ismét az
// 'i' változót használhatjuk, nem kell újabb számálónevet bevezetni.

for (int i = 100; i < 200; i++)
{
    // Nem ír ki hibát, hogy újra deklaráltunk már bevezett változót.
    // Ez már másik 'i' egy másik kódblokkban, nem "látják" egymást.
    // Nincs olyen hibaüzenet, mint amit esetleg korábban láthattunk:
    // "A local or parameter named 'i' cannot be declared in this scope"
}

/* GONDOLAT A TISZTA KÓDOLÁSRÓL
 *
 * Felmerülhet a kérdés: nem sérti ez a tiszta kódolás irányelveit?
 * Nem arról volt szó eddig, hogy beszédes változóneveket használjunk?
 *
 * A felvetés teljesen jogos, de az 'i' változó nagyon is beszédes! 
 * Minden programozónak ugyanazt az egyezményes jelentést hordozza:
 * - "Ez egy sima, egyszerű számlálós ciklus"
 * - "Az 'i' pont azt fogja jelenti, amit vársz"
 * - "Ne foglalkozz vele, mert jelentékteleten"
 *
 * Más névválasztás esetén pedig pont az ellenkezőjét hangsúlyozzuk:
 * "Vigyázz! Ennek nem véletlenül adtam teljesen eltérő nevet!"
 * "Valószínűleg nagyon jó oka volt, hogy nem 'i'-t használtam!"
 * "Lehet meg kéne állni egy pillanatra, értelmezni, hogy mért."
 */

// Az iterátort tetszőleges számtól indíthatjuk.
// Sőt, még az sem kötelező, hogy egyesével léptessünk!
// Az "i++" helyére tetszőleges kifejezést írhatunk.

Ciklus.Pelda(5);

// Például páros számok 30 és 70 között (kettesével léptetünk)
for (int i = 30; i < 70; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();

/* ÖSSZEFOGLALVA
 * 
 * While ciklussal akármilyen ciklikus feladat megoldható. 
 * A for ciklus gyakran csak egy tömörebb alak ugyanerre,
 * ha valamiért előre tudjuk, hogy hányszor kell ismétleni.
 */

Ciklus.Vege();