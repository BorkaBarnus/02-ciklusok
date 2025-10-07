using Szemleltetes;

/* CIKLUS ('loop')
 *
 * Gyakran egy utasítást egymás után többször is végre szeretnénk hajtani.
 * Néhány változót még kiírhatunk egyesével WriteLine() utasításokkal.
 * De mit tegyünk, ha egymás után 50-100-1000 értéket kell kiíratni?
 *
 * Ezekben a helyzetekben segítenek a különböző ismétlések.
 * Más szóval a ciklusok, vagy szakkifejezéssel az iteráció ('iteration').
 * Attól függően, hogy "hányszor" szeretnénk valamit megismételni, 
 * a programnyelvek általában többféle lehetőséget is kínálnak.
 */

/* WHILE
 * 
 * "ismételd amíg ( a bekerülési feltétel teljesül ) utasítás "
 *
 * A 'while' kulcsszó után zárójelek között egy logikai feltétel áll.
 * Ez lehet true/false literál, logikai változó vagy kifejezés.
 * (ÉS, VAGY, <, > relációk, egyenlőségvizsgálat, stb.).
 *
 * Ha a feltétel igazra értékelődik ki, belépünk a ciklusba.
 * Végrehajtjuk a ciklusban szereplő utasítást, de nem lépünk tovább!
 * Helyette visszaugrunk a ciklus elejére. Újraértékeljük a feltételt.
 * Ha még mindig igaz, ismét a ciklus belsejébe kerülünk.
 * Ezt addig ismételjük, amíg feltétel egyszer hamissá nem válik.
 * 
 * Csak ekkor lépünk tovább a ciklus utáni következő kódsorra.
 */

// Szükség van tehát egy ciklusba kerülési feltételre. Egyszerű példa:
bool bekerulesiFeltetel = false;

while (bekerulesiFeltetel == true) Console.WriteLine("Ismételném");

// Ahogy az elágazásnál megszoktuk, az olvashatóság kedvéért tördeljük.
while (bekerulesiFeltetel == true)
    Console.WriteLine("Ismétlem az utasítást");

// Ha egynél több utasítás van, azokat kötelező kódblokkba foglalni.
while (bekerulesiFeltetel == true)
{
    Console.Write("Ismétlem ");
    Console.Write("az ");
    Console.Write("utasításokat.");
}

// A tévedés lehetősége miatt írjunk blokkot egyetlen utasításnál is!
while (bekerulesiFeltetel)
{
    // egyetlen utasítás vagy utasítások
}

/* PÉLDA A HIBÁRA
 * 
 * Akárcsak az elágaznál, a 'while (feltétel)' után sincs pontosvessző!
 * Ez egy alattomos hiba, figyeljünk oda! Használjunk kódkiegészítést!
 * A kódértelmező fel is hívják rá a figyelmet. De csak 'Warning' nem 
 * pedig 'Error' formájában. Nézzük meg a figyelmeztető üzenetet!
 * "Possible mistaken empty statement"
 */
while (bekerulesiFeltetel) ;
{
    // ez a kódblokk nincs a ciklusban!
}

// Vegyük észre, hogy valójában ezt írtuk:

while (bekerulesiFeltetel)
    ; // üres utasítás, nem kell semmit csinálni

{
    // ez pedig egy ettől független kódblokk.
}

/* SZEMLÉLTETÉS */

Ciklus.Pelda(1);
Ciklus.WriteLine("Billentyű leütésenként tudsz továbblépni.");
Ciklus.WriteLine("Ciklus indul... ");

int szamlalo = 0;
while (szamlalo < 5)
{
    Ciklus.WriteLine($" {szamlalo} < 5 feltétel igaz, beléptem.");
    szamlalo++;
}
Ciklus.WriteLine($"Ciklus leáll, mert {szamlalo} nem kisebb, mint 5.");

/* HATÁROZATLAN & ELÖLTESZTELŐS
 * 
 * Mivel a feltételvizsgálat a ciklusba kerülés _előtt_ történik,
 * ezért szokták "elöl- vagy előtesztelős" ciklusnak is nevezik.
 * Sejthetjük, hogy akkor lesz "hátul- vagy utótesztelős" párja is.
 *
 * Mind feladatra alkalmas, de jellemzően olyan problémánál használjuk, 
 * ahol a leállás valamilyen "külső" feltételtül teljesülésétől függ.
 * Ezért gyakran nem is tudjuk előre, hogy ez mikor fog bekövetkezni.
 * 
 * A ciklusban lévő utasítások azok, amik változtathatnak a feltételen.
 * Ezért előbb-utóbb az ismétlés véget ér, és a program folytatódhat.
 */

Ciklus.Pelda(2);

Console.WriteLine("Írj be bármit!");
Console.Write("Akkor hagyom abba, ha azt írod hogy 'NEM'");

while (Console.ReadLine() != "NEM")
{
    Console.Write("  Folytassam? ");
}

Console.WriteLine("Rendben, befejeztem...");

/* VÉGTELEN CIKLUS ('infinite loop')
 * 
 * Ciklusok feltételének írásakor legyünk körültekintőek!
 * Ha a bekerülési / bentmaradási feltétel sosem lesz hamis, 
 * akkor a ciklusból nem lehet kilépni és "örökké" ismétlődne.
 * 
 * Sem a kódelemző, de még a fordító sem figyelmeztet rá.
 * Hiszen ez technikailag nem egy hiba! Van amikor épp ezt akarjuk.
 * Addig ismételni valamit, amíg be nem zárják a programot.
 */

// Vegyük ki a megyjegyzéjeleket, és nézzük meg mi történik!

/*
Ciklus.Példa(3);

int lepteto = 0;
bool ismetelheted = true;

while (ismetelheted)
{
    Ciklus.Write(lepteto + " ");
    lepteto++;
}
*/

/* ÖSSZEFOGLALVA
 * 
 *   while ( bekerülési feltétel )
 *   {
 *      parancsok, de végtelen ciklusra figyelünk!
 *   }
 * 
 * Akkor praktikus, ha nem tudjuk előre, hányszor kell majd ismételni.
 * Vagy épp azt akarjuk meghatározni, hogy mennyiszer hajtottuk végre.
 */

Ciklus.Vege();