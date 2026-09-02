using System;
using System.Collections.Generic;

namespace ModulAjar
{
    public class Bab14
    {
        public static void Jalankan()
        {
            bool kembali = false;

            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("         BAB 14: PENGENALAN OOP PADA C#           ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- MATERI & CONTOH ---");
                Console.WriteLine(" 1. Contoh: Class dan Object Siswa");
                Console.WriteLine(" 2. Contoh: Field, Property, dan Method");
                Console.WriteLine(" 3. Contoh: Constructor");
                Console.WriteLine(" 4. Contoh: Encapsulation Sederhana");
                Console.WriteLine(" 5. Contoh: Mini Project Mobil");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 6. Studi Kasus 1: Class Siswa (Nama & Nilai)");
                Console.WriteLine(" 7. Studi Kasus 2: Class PersegiPanjang");
                Console.WriteLine(" 8. Studi Kasus 3: Class Rekening (Setor & Lihat Saldo)");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 9. Latihan 1: Class Buku (Judul & Penulis)");
                Console.WriteLine(" 10. Latihan 2: Class Mahasiswa (TampilData)");
                Console.WriteLine(" 11. Latihan 3: Constructor dengan Dua Parameter");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Pilih menu (0-14): ");

                string pilihan = Console.ReadLine();
                if (pilihan == "0")
                {
                    kembali = true;
                    return;
                }

                Console.Clear();
                switch (pilihan)
                {
                    case "1":
                        Contoh1_ClassSiswa();
                        break;
                    case "2":
                        Contoh2_FieldPropertyMethod();
                        break;
                    case "3":
                        Contoh3_Constructor();
                        break;
                    case "4":
                        Contoh4_Encapsulation();
                        break;
                    case "5":
                        Contoh5_MiniProjectMobil();
                        break;
                    case "6":
                        StudiKasus1_Siswa();
                        break;
                    case "7":
                        StudiKasus2_PersegiPanjang();
                        break;
                    case "8":
                        StudiKasus3_Rekening();
                        break;
                    case "9":
                        Latihan1_Buku();
                        break;
                    case "10":
                        Latihan2_Mahasiswa();
                        break;
                    case "11":
                        Latihan3_ConstructorParameter();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                if (!kembali)
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 14...");
                    Console.ReadLine();
                }
            }
        }

        // ----------------------------------------------------
        // IMPLEMENTASI CONTOH MATERI (SESUAI MODUL BAB 14)
        // ----------------------------------------------------
        private static void Contoh1_ClassSiswa()
        {
            Console.WriteLine("=== CONTOH: CLASS DAN OBJECT SISWA ===");
            SiswaModul s1 = new SiswaModul();
            s1.Nama = "Andi";
            s1.Umur = 16;
            Console.WriteLine($"Nama: {s1.Nama}, Umur: {s1.Umur} tahun");
        }

        private static void Contoh2_FieldPropertyMethod()
        {
            Console.WriteLine("=== CONTOH: FIELD, PROPERTY, DAN METHOD ===");
            SiswaFPM s = new SiswaFPM();
            s.Nama = "Budi";
            s.Tampil();
        }

        private static void Contoh3_Constructor()
        {
            Console.WriteLine("=== CONTOH: CONSTRUCTOR ===");
            SiswaConstructor s = new SiswaConstructor("Budi");
            Console.WriteLine($"Nama dari constructor: {s.Nama}");
        }

        private static void Contoh4_Encapsulation()
        {
            Console.WriteLine("=== CONTOH: ENCAPSULATION SEDERHANA ===");
            RekeningModul rek = new RekeningModul();
            rek.Setor(500000);
            rek.Setor(250000);
            Console.WriteLine($"Saldo saat ini: Rp {rek.LihatSaldo():N0}");
        }

        private static void Contoh5_MiniProjectMobil()
        {
            Console.WriteLine("=== MINI PROJECT MOBIL ===");
            MobilModul m = new MobilModul();
            m.Merk = "Toyota";
            m.Jalan();
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI MODUL BAB 14)
        // ----------------------------------------------------
        private static void StudiKasus1_Siswa()
        {
            Console.WriteLine("=== STUDI KASUS 1: CLASS SISWA (NAMA & NILAI) ===");
            StudiKasusSiswaModul s = new StudiKasusSiswaModul();
            Console.Write("Masukkan Nama Siswa : ");
            s.Nama = Console.ReadLine();
            Console.Write("Masukkan Nilai Siswa: ");
            s.Nilai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nData Siswa -> Nama: {s.Nama}, Nilai: {s.Nilai}");
        }

        private static void StudiKasus2_PersegiPanjang()
        {
            Console.WriteLine("=== STUDI KASUS 2: CLASS PERSEGI PANJANG ===");
            StudiKasusPPModul pp = new StudiKasusPPModul();
            Console.Write("Masukkan Panjang: ");
            pp.Panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar  : ");
            pp.Lebar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Luas Persegi Panjang = {pp.HitungLuas()}");
        }

        private static void StudiKasus3_Rekening()
        {
            Console.WriteLine("=== STUDI KASUS 3: CLASS REKENING (SETOR & LIHAT SALDO) ===");
            StudiKasusRekeningModul rek = new StudiKasusRekeningModul();
            bool lanjut = true;
            while (lanjut)
            {
                Console.WriteLine("\n1. Setor Uang");
                Console.WriteLine("2. Lihat Saldo");
                Console.WriteLine("3. Selesai");
                Console.Write("Pilih (1-3): ");
                string p = Console.ReadLine();
                if (p == "1")
                {
                    Console.Write("Masukkan jumlah setor: Rp ");
                    double jml = Convert.ToDouble(Console.ReadLine());
                    rek.Setor(jml);
                }
                else if (p == "2")
                {
                    Console.WriteLine($"Saldo saat ini: Rp {rek.LihatSaldo():N0}");
                }
                else if (p == "3")
                {
                    lanjut = false;
                }
            }
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI MODUL BAB 14)
        // ----------------------------------------------------
        private static void Latihan1_Buku()
        {
            Console.WriteLine("=== LATIHAN 1: CLASS BUKU (JUDUL & PENULIS) ===");
            BukuModul b = new BukuModul();
            Console.Write("Masukkan Judul Buku  : ");
            b.JudulBuku = Console.ReadLine();
            Console.Write("Masukkan Nama Penulis: ");
            b.Penulis = Console.ReadLine();

            Console.WriteLine($"\nBuku tersimpan -> Judul: {b.JudulBuku}, Penulis: {b.Penulis}");
        }

        private static void Latihan2_Mahasiswa()
        {
            Console.WriteLine("=== LATIHAN 2: CLASS MAHASISWA (METHOD TAMPILDATA) ===");
            MahasiswaModul mhs = new MahasiswaModul();
            Console.Write("Masukkan Nama Mahasiswa: ");
            mhs.Nama = Console.ReadLine();
            mhs.TampilData();
        }

        private static void Latihan3_ConstructorParameter()
        {
            Console.WriteLine("=== LATIHAN 3: CONSTRUCTOR DUA PARAMETER ===");
            Console.Write("Masukkan Parameter 1 (Misal: Judul): ");
            string p1 = Console.ReadLine();
            Console.Write("Masukkan Parameter 2 (Misal: Penulis): ");
            string p2 = Console.ReadLine();

            LatihanConstructorDuaParamModul obj = new LatihanConstructorDuaParamModul(p1, p2);
            obj.TampilkanInfo();
        }
    }

    // ========================================================
    // STRUKTUR KELAS PENDUKUNG 
    // ========================================================

    public class SiswaModul
    {
        public string Nama;
        public int Umur;
    }

    public class SiswaFPM
    {
        public string Nama { get; set; }
        public void Tampil()
        {
            Console.WriteLine($"Nama: {Nama}[cite: 3]");
        }
    }

    public class SiswaConstructor
    {
        public string Nama;
        public SiswaConstructor(string nama)
        {
            Nama = nama;
        }
    }

    public class RekeningModul
    {
        private double saldo;
        public void Setor(double jumlah)
        {
            saldo += jumlah;
        }
        public double LihatSaldo()
        {
            return saldo;
        }
    }

    public class MobilModul
    {
        public string Merk { get; set; }
        public void Jalan()
        {
            Console.WriteLine($"{Merk} sedang berjalan.[cite: 3]");
        }
    }

    public class StudiKasusSiswaModul
    {
        public string Nama { get; set; }
        public double Nilai { get; set; }
    }

    public class StudiKasusPPModul
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }
        public double HitungLuas()
        {
            return Panjang * Lebar;
        }
    }

    public class StudiKasusRekeningModul
    {
        private double saldo = 0;
        public void Setor(double jumlah)
        {
            saldo += jumlah;
            Console.WriteLine("Setor tunai berhasil.");
        }
        public double LihatSaldo()
        {
            return saldo;
        }
    }

    public class BukuModul
    {
        public string JudulBuku { get; set; }
        public string Penulis { get; set; }
    }

    public class MahasiswaModul
    {
        public string Nama { get; set; }
        public void TampilData()
        {
            Console.WriteLine($"Nama Mahasiswa: {Nama}");
        }
    }

    public class LatihanConstructorDuaParamModul
    {
        public string Param1;
        public string Param2;

        public LatihanConstructorDuaParamModul(string p1, string p2)
        {
            Param1 = p1;
            Param2 = p2;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nilai Parameter 1: {Param1}");
            Console.WriteLine($"Nilai Parameter 2: {Param2}");
        }
    }

    public class ClassA
    {
        public string Info { get; set; }
        public void Tampilkan() { Console.WriteLine($"[Class A]: {Info}"); }
    }

    public class ClassB
    {
        public string Info { get; set; }
        public void Tampilkan() { Console.WriteLine($"[Class B]: {Info}"); }
    }

    public class ClassC
    {
        public string Info { get; set; }
        public void Tampilkan() { Console.WriteLine($"[Class C]: {Info}"); }
    }

    public class AplikasiOOPModul
    {
        public void Jalankan()
        {
            Console.WriteLine("Simulasi aplikasi berbasis OOP berjalan...");
            MobilModul m = new MobilModul();
            m.Merk = "Suzuki";
            m.Jalan();
        }
    }
}