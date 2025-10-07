int vizsga = 123456789;
bool isPrime = true;

for (int i = 2; i < vizsga; i++)
{
    if (vizsga % i == 0)
    {
        isPrime = false;    
    }
}