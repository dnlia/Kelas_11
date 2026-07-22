// METHOD
using System.Security.Cryptography;

static void Salam()
{
    Console.WriteLine("Hello World");
}

Salam();


// METHOD DENGAN PARAMETER
static void Sapa(string nama)
{
    Console.WriteLine("Halo " + nama);
}

Sapa("Jimin");


// METHOD DENGAN RETURN VALUE
static int Tambah(int a, int b)
{
    return a + b;
}

Console.WriteLine(Tambah(5, 7));