for (int row = 0; row < 8; row++)
{
    for (int col = 0; col < 8; col++)
    {
        if (col % 2 == row % 2)
        {
            Console.Write('■');
        }
        else
        {
            Console.Write('-');
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
/********************/
string palya = "";
int meret = 64;

for (int i = 1; i != 64; i++)
{
    if (i % 2 == 0)
    {
        palya += "-";
    }
    else
    {
        palya += "■";
    }
    if (i == 0)
    {
        continue;
    }
    if (i % 9 == 0)
    {
        palya += "\n";
    }
}
Console.WriteLine(palya);