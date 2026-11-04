using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab13
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("          BAB 13: METHOD (FUNGSI) PADA C#         "); //[cite: 2]
                Console.WriteLine("==================================================");
                Console.WriteLine("--- MATERI ---");
                Console.WriteLine(" 1. Materi 1: Pengertian & Struktur Method"); //[cite: 2]
                Console.WriteLine(" 2. Materi 2: Method dengan Parameter & Argumen"); //[cite: 2]
                Console.WriteLine(" 3. Materi 3: Method Void dan Non-Void (Return)"); //[cite: 2]
                Console.WriteLine(" 4. Materi 4: Method Overloading"); //[cite: 2]
                Console.WriteLine(" 5. Materi 5: Scope Variabel"); //[cite: 2]
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 6. Studi Kasus 1: Menghitung Luas Persegi Panjang"); //[cite: 2]
                Console.WriteLine(" 7. Studi Kasus 2: Menghitung Luas Lingkaran"); //[cite: 2]
                Console.WriteLine(" 8. Studi Kasus 3: Menentukan Bilangan Genap/Ganjil"); //[cite: 2]
                Console.WriteLine();
                Console.WriteLine("--- MINI PROJECT ---");
                Console.WriteLine(" 9. Mini Project: Hitung Rata-Rata Nilai"); //[cite: 2]
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine("10. Latihan 1: Method Keliling Persegi"); //[cite: 2]
                Console.WriteLine("11. Latihan 2: Method Faktorial"); //[cite: 2]
                Console.WriteLine("12. Latihan 3: Method Pangkat Bilangan"); //[cite: 2]
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Pilih Menu (0-12): ");

                string pilihan = Console.ReadLine()?.Trim();

                switch (pilihan)
                {
                    case "0":
                        return;
                    case "1":
                        Console.Clear();
                        MateriPengertian();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        MateriParameter();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        MateriVoidDanReturn();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        MateriOverloading();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        MateriScope();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        StudiKasusLuasPersegiPanjang();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        StudiKasusLuasLingkaran();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        StudiKasusGenapGanjil();
                        TahanLayar();
                        break;
                    case "9":
                        Console.Clear();
                        MiniProjectHitungRata();
                        TahanLayar();
                        break;
                    case "10":
                        Console.Clear();
                        LatihanKelilingPersegi();
                        TahanLayar();
                        break;
                    case "11":
                        Console.Clear();
                        LatihanFaktorial();
                        TahanLayar();
                        break;
                    case "12":
                        Console.Clear();
                        LatihanPangkat();
                        TahanLayar();
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid!");
                        TahanLayar();
                        break;
                }
            }
        }

        private static void TahanLayar()
        {
            Console.WriteLine("\nTekan Enter untuk kembali ke Menu Bab 13...");
            Console.ReadLine();
        }

        // --- MATERI MODUL ---

        // Contoh Method Void Sederhana
        private static void Sapa()
        {
            Console.WriteLine("Selamat Datang"); 
        }

        private static void MateriPengertian()
        {
            Console.WriteLine("=== MATERI 1: PENGERTIAN & STRUKTUR METHOD ===");
            Console.WriteLine("Method (fungsi) adalah sekumpulan perintah yang dikelompokkan menjadi"); //[cite: 2]
            Console.WriteLine("satu bagian untuk menjalankan tugas tertentu dan dapat dipanggil berulang kali.\n"); //[cite: 2]

            Console.WriteLine("Memanggil method Sapa():");
            Sapa(); 
        }

        // Method dengan Parameter[cite: 2]
        private static void Sapa(string nama)
        {
            Console.WriteLine($"Halo {nama}"); 
        }

        private static void MateriParameter()
        {
            Console.WriteLine("=== MATERI 2: PARAMETER DAN ARGUMEN ===");
            Console.WriteLine("Memanggil Sapa(\"Andi\"):");
            Sapa("Andi"); 
        }

        // Method dengan Return Value
        private static int Tambah(int a, int b)
        {
            return a + b;
        }

        private static void MateriVoidDanReturn()
        {
            Console.WriteLine("=== MATERI 3: METHOD VOID DAN NON-VOID ===");
            Console.WriteLine("• Method void tidak mengembalikan nilai."); 
            Console.WriteLine("• Method non-void mengembalikan nilai menggunakan keyword return.\n"); 

            int hasil = Tambah(10, 5); 
            Console.WriteLine($"Hasil Tambah(10, 5) = {hasil}");
        }

        // Method Overloading
        private static int Hitung(int a, int b)
        {
            return a + b;
        }

        private static double Hitung(double a, double b)
        {
            return a + b; 
        }

        private static void MateriOverloading()
        {
            Console.WriteLine("=== MATERI 4: METHOD OVERLOADING ===");
            Console.WriteLine("Method Overloading mengizinkan nama method sama dengan tipe data parameter berbeda.\n");

            Console.WriteLine($"Hitung(int 5, 10) = {Hitung(5, 10)}");
            Console.WriteLine($"Hitung(double 3.5, 2.5) = {Hitung(3.5, 2.5)}"); 
        }

        private static void MateriScope()
        {
            Console.WriteLine("=== MATERI 5: SCOPE VARIABEL ===");
            Console.WriteLine("Variabel lokal hanya dapat digunakan di dalam method tempat variabel tersebut dibuat.\n"); 

            int x = 10; 
            Console.WriteLine($"Nilai variabel lokal x = {x}"); 
        }

        // --- STUDI KASUS MODUL ---

        // Studi Kasus 1: Menghitung luas persegi panjang
        private static double HitungLuasPersegiPanjang(double p, double l)
        {
            return p * l;
        }

        private static void StudiKasusLuasPersegiPanjang()
        {
            Console.WriteLine("=== STUDI KASUS 1: LUAS PERSEGI PANJANG ===");
            Console.Write("Masukkan Panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Luas Persegi Panjang = {HitungLuasPersegiPanjang(p, l)}");
        }

        // Studi Kasus 2: Menghitung luas lingkaran
        private static double HitungLuasLingkaran(double r)
        {
            return Math.PI * r * r;
        }

        private static void StudiKasusLuasLingkaran()
        {
            Console.WriteLine("=== STUDI KASUS 2: LUAS LINGKARAN ==="); 
            Console.Write("Masukkan Jari-jari (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Luas Lingkaran = {HitungLuasLingkaran(r):F2}");
        }

        // Studi Kasus 3: Menentukan bilangan genap atau ganjil
        private static bool IsGenap(int angka)
        {
            return angka % 2 == 0;
        }

        private static void StudiKasusGenapGanjil()
        {
            Console.WriteLine("=== STUDI KASUS 3: CEK GENAP / GANJIL ==="); //[cite: 2]
            Console.Write("Masukkan Angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (IsGenap(angka))
                Console.WriteLine($"{angka} adalah Bilangan Genap.");
            else
                Console.WriteLine($"{angka} adalah Bilangan Ganjil.");
        }

        // --- MINI PROJECT MODUL ---

        // Mini Project: HitungRata[cite: 2]
        private static double HitungRata(int a, int b, int c)
        {
            return (a + b + c) / 3.0; //[cite: 2]
        }

        private static void MiniProjectHitungRata()
        {
            Console.WriteLine("=== MINI PROJECT: HITUNG RATA-RATA NILAI ==="); //[cite: 2]
            Console.Write("Masukkan Nilai 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai 3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nRata-rata Nilai = {HitungRata(n1, n2, n3):F2}"); //[cite: 2]
        }

        // --- LATIHAN MODUL ---

        // Latihan 1: Method menghitung keliling persegi[cite: 2]
        private static int HitungKelilingPersegi(int s)
        {
            return 4 * s;
        }

        private static void LatihanKelilingPersegi()
        {
            Console.WriteLine("=== LATIHAN 1: KELILING PERSEGI ==="); //[cite: 2]
            Console.Write("Masukkan Panjang Sisi: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Keliling Persegi = {HitungKelilingPersegi(s)}");
        }

        // Latihan 2: Method menghitung faktorial[cite: 2]
        private static long HitungFaktorial(int n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
            }
            return hasil;
        }

        private static void LatihanFaktorial()
        {
            Console.WriteLine("=== LATIHAN 2: HITUNG FAKTORIAL ==="); //[cite: 2]
            Console.Write("Masukkan Angka (n!): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n}! = {HitungFaktorial(n)}");
        }

        // Latihan 3: Method menghitung pangkat bilangan[cite: 2]
        private static double HitungPangkat(double alas, double pangkat)
        {
            return Math.Pow(alas, pangkat);
        }

        private static void LatihanPangkat()
        {
            Console.WriteLine("=== LATIHAN 3: HITUNG PANGKAT BILANGAN ==="); //[cite: 2]
            Console.Write("Masukkan Angka Alas: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Pangkat: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hasil {a}^{p} = {HitungPangkat(a, p)}");
        }
    }
}