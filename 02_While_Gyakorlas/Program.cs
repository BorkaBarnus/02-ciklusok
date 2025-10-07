using Szemleltetes;

/* FELADAT - NÉGYZETSZÁM */

Ciklus.Pelda(1);

// A 'while()' ciklus akkor is praktikus, ha arra vagyunk kíváncsiak,
// hogy egy határozatlan ideig tartó ismétlés hány lépés után ér véget.
// 1-től indulva kezdjük el sorban négyzetre emelni az egész számokat!
// Melyik lesz az első olyan szám, aminek négyzete nagyobb mint 12345?

int keresett = 12345;
int aktualis = 1;
int negyzete = 1;

Console.WriteLine($"Az első vizsgált szám {aktualis}. Ismétlés indul,");
Console.WriteLine($"amíg a négyzete nem nagyobb, mint {keresett}.");
Console.WriteLine();

while (negyzete < keresett)
{
    Ciklus.Write(aktualis + " ");
    aktualis++;
    negyzete = aktualis * aktualis;
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Ahol {aktualis} számnál leállt");
Console.WriteLine($"Mert {aktualis}^2 = {negyzete} > {keresett}");

// Tesztelésképpen próbáljuk ki másik plafonnal is!

/* FELADAT - BINÁRIS ÁTALAKÍTÓ */

Ciklus.Pelda(2);

// Váltsunk át egy tízes számrendszű pozitív egész számot binárisra!
// Feljegyezzük, hogy mennyi lenne a szám kettővel osztott maradéka.
// Majd el is osztjuk kettővel, de a tizedesjegyektől eltekintünk.
// Ismételjük, amíg a szám nulla lesz. Ekkor ha a maradékként felírt
// számjegyeket visszafelé összeolvassuk, a szám bináris alakját kapjuk.

// Például
// 57 / 2 maradéka 1
// 28 / 2 maradéka 0
// 14 / 2 maradéka 0  
// 7  / 2 maradéka 1
// 1  / 2 maradéka 1
// 3  / 2 maradéka 1
// 0  leállunk, és lentről felfelé olvassuk
// 57(dec) = 111001(bin)

int decimalis = 57;
string binarisan = "";

while (decimalis != 0)
{
    // Ez még nem az osztás, csak a kettővel képzett maradék értéke!
    int osztasMaradeka = decimalis % 2;

    // Maradék feljegyzése. A "fordítva olvasás" = a szöveg elejére fűzés.
    // Jelentése: a "binarisan" nevű változóban tároljunk egy új értéket.
    // Ez legyen ugyanaz, mint eddig volt, csak még hozzáfűzve egy szám.
    binarisan = osztasMaradeka + binarisan;

    // Példa a rövidített értékadó operátor használatára osztásnál.
    // A hosszú alakban ezt íruk volna: decimalis = decimalis / 2
    decimalis /= 2;
}

Console.WriteLine("Az eredeti szám binárisan:");
Console.WriteLine(binarisan);

/* FELADAT - BANKKÁRTYA */

Ciklus.Pelda(3);

// Számlát vezetünk egy banknál. A nyitó egyenlegünk 98765.00 forint.
// Hitelkártyával többször is készpénzt szeretnénk felvenni automatából.
// Az első két alkalom ingyenes. Utána mindig fix 432 Ft alapköltséget,
// és a felvett összeg 1%-át kell fizetni kezelési díjként.
// Túlléphetjük a keretünket. De utána már nem tudunk pénzt felvenni.

// Kérdezzünk meg a felhasználótól, mekkora összeget szeretne felvenni!
// Feltételehetjük, hogy helyes értéket fog megadni (egy egész számot).
// Csökkentsük az egyenlegét, számoljuk a tranzakciókat! Ezt ismételjük
// amíg a pénzfelvételt megtagadja a bank, mert az egyenlegünk negatív.
// Utána írjuk ki, hogy "Nincs több fedezet, a tartozásod valahány Ft"!

double egyenleg = 98765;
int fixKoltseg = 432;
double dijSzazalek = 0.01;
int alkalmakSzama = 0;

while (egyenleg > 0)
{
    Console.WriteLine($"Egyenleged {egyenleg} forint");
    Console.Write("Felvett összeg? ");
    string beirtSzoveg = Console.ReadLine();
    int felvettOsszeg = int.Parse(beirtSzoveg);

    egyenleg -= felvettOsszeg;

    alkalmakSzama++;

    if (alkalmakSzama > 2)
    {
        egyenleg -= fixKoltseg;
        egyenleg -= felvettOsszeg * dijSzazalek;
    }
}

Console.WriteLine();
Console.WriteLine($"Nincs több fedezet, a tartozásod {egyenleg} Ft");

Ciklus.Vege();