using System.Diagnostics.Contracts;

int vizsga = 123456789;
bool isPrime = true;

for (int i = 2; i < vizsga && isPrime; i++)
{
    if (vizsga % i == 0)
    {
        isPrime = false;

        Console.WriteLine(i);
    }
}

if (isPrime)
{
    Console.WriteLine("Ige,n ez prím volt");
}
else