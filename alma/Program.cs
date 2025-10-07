int szamlalo = 0;
int platform = 100;
while(szamlalo < platform)
{
    Console.WriteLine($"Itt állok: {szamlalo}");

    //eggyel léptetés
    szamlalo++; 
}

/*
 * for(
 * változó(k);
 * feltétel(ek);
 * léptetés(ek);
 * )
 * 
 * {
 * //végrehajtandó utasítás}
 */

for (int i = 0; i < 1000; i+= 10)
{
    Console.Write(i + " ");
}

for (int i = 0; i < 1024; i *= 2)
{
    
}

/*
 * for i in range(0, 100, 1):
 *  print(i)
 * 
 * #ciklus vége
 * print(i)
 */