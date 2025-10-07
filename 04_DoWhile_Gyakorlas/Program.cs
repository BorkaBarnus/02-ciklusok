/* FELADAT - BELÉPTETÉS
 * 
 * Tároljunk változóban egy e-mail címet (például "admin@umszki.hu")
 * Valamint egy hozzá tartozó jelszót is (mondjuk "Umszki2021?!")
 * 
 * "Léptessük" be a felhasználót! Kérjünk e-mail címet, majd jelszót!
 * Ezt addig ismételjük, amíg a felhasználó helyes adatokat nem ad meg!
 */

string taroltUser = "admin@umszki.hu";
string taroltPass = "Umszki2021?!";

string beirtUser;
string beirtPass;

do
{
    Console.Write("E-mail: ");
    beirtUser = Console.ReadLine();

    Console.Write("Jelszó: ");
    beirtPass = Console.ReadLine();

    Console.Clear();

} while (beirtUser != taroltUser || beirtPass != taroltPass);

Console.WriteLine("Beléptél!");
Console.ReadKey();

/* GONDOLKOTATÓ 
 * 
 * Ha sikerült megoldani, nehezítésként legfeljebb 3x próbálkozhasson!
 * (utána állítsuk le a ciklus, és belépés helyett írjuk ki "Kitiltva!")
 * 
 * TISZTA KÓDOLÁS
 * 
 * Mit tegyünk, ha a feltétel elkezd túl burjánzani?
 */