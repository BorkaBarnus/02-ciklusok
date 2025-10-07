int egyik = 0;
int masik = 1;

for (int i = 0; i < 10; i++);
{
    int következő = egyik + masik;
    egyik = masik;
    masik = következő;
}

Console.WriteLine(egyik);
Console.WriteLine(masik);