// ARRAY

string[] namaBuah = { "Apel", "Mangga", "Jeruk" };

//Console.WriteLine(namaBuah[0]);
//Console.WriteLine(namaBuah[2]);

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}


// KOLEKSI DASAR: LIST
List<string> namaSiswa = new List<string>();

namaSiswa.Add("Jimin");
namaSiswa.Add("Jungkook");
namaSiswa.Add("Taetae");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}