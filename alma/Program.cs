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

for (int i = 0; i < 100; i++)
{
    Console.Write(i + " ");
}