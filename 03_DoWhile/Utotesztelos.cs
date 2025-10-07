using Szemleltetes;

/* ISMÉTLÉS
 * 
 * A 'while' ciklus először megvizsgálja a bekerülés feltételét.
 * Ha igaz volt, akkor végrehajtja az utasítást. Majd újraindul.
 * Megint kiértékeli a feltételt. Ismétli, amíg az hamis nem lesz.
 *
 * Ez a felépítés néha nem praktikus. Példéul, ha a ciklus indulásakor 
 * a feltétel nem értelmezhető, mert a változó még nem kapott értéket.
 * Mondjuk mert a felhasználó még be sem írta a nevét és a jelszavát.
 * Ilyen esetekben értelemszerűen nem is lenne még mit ellenőrizni.
 * 
 * Az utasítást sokszor legalább egyszer biztosan végre kell hajtani.
 * Csak utána akarjuk megvizsgálni, hogy kell-e még tovább ismételni.
 * 
 * Ilyenkor praktokus DO-WHILE szerkezet
 * 
 * ismételd 
 * { 
 *    az utasításokat
 * } 
 * amíg ( a bentmaradási feltétel teljesül )
 * 
 */

// Egyszerű példa

bool bentmaradasiFeltetel = false;

do
{
    // utasítások
}
while (bentmaradasiFeltetel == true);

// Mivel a feltétel vizsgálata az aktuális futam után történik,
// ezért szokás "hátul- vagy utótesztelős" ciklusnak is nevezni.
// Hasonlítsuk össze a korábban megismert ciklus működésével!
// Hányszor fut le az egyik ciklus, hányszor ismétlődik a másik?

Ciklus.Pelda(1);

Ciklus.WriteLine("Előteszt START");

while (bentmaradasiFeltetel)
{
    Ciklus.WriteLine("...");
}

Ciklus.WriteLine("Előteszt STOP");
Console.WriteLine();

// illetve

Ciklus.WriteLine("Utóteszt START");

do
{
    Ciklus.WriteLine("...");
}
while (bentmaradasiFeltetel);

Ciklus.WriteLine("Utóteszt STOP");
Console.WriteLine();

/* FIGYELJÜNK ODA!
 * 
 * A do { } while() ; szerkezet végén kell egy pontosvessző!
 * Az elfelejtésére szerencsére a kódértelmező is hibát ír ki.
 * De kódkiegészítés használatával ilyesmi elő sem fordulhat.
 * 
 * Próbáljuk ki! 
 * wh tab tab
 * 
 * Illetve
 * do tab tab
 */

Ciklus.Pelda(2);

// Olvassuk be a felhasználó nevét! Ismételjük addig, míg üresen hagyná!

string nev;

do
{
    Console.Write("Add meg a neved: ");
    nev = Console.ReadLine();
}
while (nev == "");

// ciklusból kilépés után
Console.WriteLine("Üdv, " + nev);

/* FELADAT - TIPPELŐS JÁTÉK
 * 
 * A számítógép "gondoljon" egy számra. Próbáljuk meg kitalálni! 
 * Szóljon a gép, ha kicsit/nagyott tippeltünk. Ha eltaltunk, nyertünk.
 */

Ciklus.Pelda(3);

int gondolt = 42;
int tippelt;

do
{
    Console.Write("Tippelj egy számra! ");
    tippelt = int.Parse(Console.ReadLine());

    if (tippelt > gondolt)
        Console.WriteLine(" Túl nagy! ");
    else if (tippelt < gondolt)
        Console.WriteLine(" Túl kicsi! ");
    else
        Console.WriteLine(" Eltaláltad! ");
}
while (tippelt != gondolt); // bentmaradási feltétel

// ciklusból kilépés után
Console.WriteLine($" Tényleg {gondolt} szám volt. Nyertél!");

/* FELADAT - KOMPLEXEBB JÁTÉK
 * 
 * Próbáljunk meg úgy kiegészíteni, hogy a játékosnak legyen "élete".
 * Számoljuk a próbálkozásait! A játék úgy is véget érhet, 
 * ha a játékosnak "elfogy" az élete. Többet próbálkozott, mint szabad.
 */

Ciklus.Pelda(4);

int elhasznaltElet = 0;
int maxProbalkozas = 3;

do
{
    Console.Write("Tippelj egy számra! ");
    tippelt = int.Parse(Console.ReadLine());
    elhasznaltElet++;

    if (tippelt > gondolt)
        Console.Write(" Túl nagy, tippelj kisebbet! ");
    else if (tippelt < gondolt)
        Console.Write(" Túl kicsi, mondj nagyobbat! ");
    else
        Console.WriteLine($" A szám tényleg {gondolt} volt! ");
}
while ((tippelt != gondolt) && (elhasznaltElet <= maxProbalkozas));

// Most viszont nem írhatjuk ki egyből, hogy nyert vagy veszített!
// Hiszen a felhasználó ciklusból kétféleképpen is ki lehet lépni
// (akkor is, ha a tipp helyes volt, vagy ha túé sokszor próbálkozna)

// Tehát az ismétlés után vizsgálnunk kell, hogy az miért ért véget!
// Ezt többféleképpen elgondolás mentén is megtehetjük:
// 1. A tipp megegyezik a gondolt számmal? Nyert
// 2. A játékosnak marad még próbálkozása? Nyert
// 3. A tipp most eltér a gondolt számtól? Vesztett
// 4. A játékosnak nem marad próbálkozása? Vesztett

if (tippelt == gondolt)
    Console.WriteLine("Nyertél! {0} próbálkozásból", elhasznaltElet);
else
    Console.WriteLine("Vesztettél... A szám {0} volt.", gondolt);

/* GONDOLAT A TISZTA KÓDOLÁSRÓL
 * 
 * Ez most egy szándékosan "egyszerű" példa volt. Ezt úgy értem, hogy
 * azért "elképzelhető" ennél összetettebb bentmaradási feltételt is.
 * Ekkor sok/bonyolult logikai vizsgálat lenne, amit nehéz kiolvasni.
 * Felvehetnénk segédváltozókat, hogy megkönnyítsük az értelmezést...
 */

Ciklus.Pelda(5);

elhasznaltElet = 0;
bool nemTalaltaEl = true;
bool probalkozhat = true;

do
{
    Console.Write("Tippelj egy számra! ");
    tippelt = int.Parse(Console.ReadLine());
    elhasznaltElet++;

    Console.WriteLine($" {elhasznaltElet}/{maxProbalkozas} próbálkozás");

    if (tippelt > gondolt)
        Console.Write(" Túl nagy, tippelj kisebbet! ");
    else if (tippelt < gondolt)
        Console.Write(" Túl kicsi, mondj nagyobbat! ");
    else
        nemTalaltaEl = false;

    if (elhasznaltElet == maxProbalkozas)
        probalkozhat = false;
}
while (nemTalaltaEl && probalkozhat);

// Ennek előnye, hogy a logikai változót később is használhatjuk.

if (nemTalaltaEl)
    Console.WriteLine($"Vesztettél... A szám {gondolt} volt.");
else
    Console.WriteLine($"Nyertél {elhasznaltElet} próbálkozásból!");

// Vagy a másikat

if (probalkozhat)
    Console.WriteLine($"Nyertél {elhasznaltElet} próbálkozásból!");
else
    Console.WriteLine($"Vesztettél... A szám {gondolt} volt.");

Ciklus.Pelda(7);

/* ÖSSZEFOGLALVA
 * 
 *   do
 *   {
 *      parancsok, végtelen ciklusra figyelünk!
 *   }
 *   while ( bentmaradási feltétel )
 * 
 * Olyan, mint a sima 'while', de legalább egyszer megcsinálja.
 */