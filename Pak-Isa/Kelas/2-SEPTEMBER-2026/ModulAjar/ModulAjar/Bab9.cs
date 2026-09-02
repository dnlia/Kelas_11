using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab9
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("          BAB 9: INPUT DAN OUTPUT PADA C#         ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- CONTOH PROGRAM ---");
                Console.WriteLine(" 1. Contoh Program Biodata");
                Console.WriteLine(" 2. Contoh Validasi Input dengan TryParse");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 3. Studi Kasus 1: Input Biodata Siswa");
                Console.WriteLine(" 4. Studi Kasus 2: Hitung Luas Persegi Panjang");
                Console.WriteLine(" 5. Studi Kasus 3: Hitung Rata-Rata Tiga Nilai");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 6. Latihan 1: Perbedaan Write() dan WriteLine()");
                Console.WriteLine(" 7. Latihan 2: Input Nama dan Tampilkan Sapaan");
                Console.WriteLine(" 8. Latihan 3: Hitung Umur dari Tahun Lahir");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-8): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        ContohProgramBiodata();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        ContohValidasiTryParse();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        StudiKasusBiodataSiswa();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        StudiKasusLuasPersegiPanjang();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        StudiKasusRataRataTigaNilai();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        LatihanPerbedaanWriteWriteLine();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        LatihanInputSapaan();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        LatihanHitungUmurTahunLahir();
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
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 9...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // CONTOH PROGRAM (SESUAI PDF MODUL BAB 9)
        // ----------------------------------------------------

        private static void ContohProgramBiodata()
        {
            Console.WriteLine("=== CONTOH PROGRAM BIODATA ===");
            Console.Write("Nama   : ");
            string nama = Console.ReadLine();
            Console.Write("Kelas  : ");
            string kelas = Console.ReadLine();
            Console.Write("Umur   : ");
            int umur = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Nama  : {nama}");
            Console.WriteLine($"Kelas : {kelas}");
            Console.WriteLine($"Umur  : {umur} tahun");
        }

        private static void ContohValidasiTryParse()
        {
            Console.WriteLine("=== VALIDASI INPUT DENGAN TRYPARSE ===");
            Console.Write("Masukkan nilai: ");
            if (int.TryParse(Console.ReadLine(), out int nilai))
            { 
                Console.WriteLine($"Nilai = {nilai}"); 
            } 
            else 
            { 
                Console.WriteLine("Input tidak valid."); 
            }
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI PDF MODUL BAB 9)
        // ----------------------------------------------------

        // Studi Kasus 1: Buat program input biodata siswa
        private static void StudiKasusBiodataSiswa()
        {
            Console.WriteLine("=== STUDI KASUS 1: INPUT BIODATA SISWA ===");
            Console.Write("Masukkan NISN         : ");
            string nisn = Console.ReadLine();
            Console.Write("Masukkan Nama Siswa   : ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan Jurusan      : ");
            string jurusan = Console.ReadLine();
            Console.Write("Masukkan Nilai Masuk  : ");
            double nilai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"NISN         : {nisn}");
            Console.WriteLine($"Nama Siswa   : {nama}");
            Console.WriteLine($"Jurusan      : {jurusan}");
            Console.WriteLine($"Nilai Masuk  : {nilai}");
        }

        // Studi Kasus 2: Buat program menghitung luas persegi panjang dari input pengguna
        private static void StudiKasusLuasPersegiPanjang()
        {
            Console.WriteLine("=== STUDI KASUS 2: LUAS PERSEGI PANJANG ===");
            Console.Write("Masukkan Panjang : ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar   : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine($"\nLuas Persegi Panjang = {luas}");
        }

        // Studi Kasus 3: Buat program menghitung rata-rata tiga nilai
        private static void StudiKasusRataRataTigaNilai()
        {
            Console.WriteLine("=== STUDI KASUS 3: RATA-RATA TIGA NILAI ===");
            Console.Write("Masukkan Nilai 1 : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai 2 : ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai 3 : ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double rataRata = (n1 + n2 + n3) / 3.0;
            Console.WriteLine($"\nRata-Rata Nilai = {rataRata}");
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI PDF MODUL BAB 9)
        // ----------------------------------------------------

        // Latihan 1: Jelaskan perbedaan Write() dan WriteLine()
        private static void LatihanPerbedaanWriteWriteLine()
        {
            Console.WriteLine("=== LATIHAN 1: PERBEDAAN WRITE() DAN WRITELINE() ===");
            Console.WriteLine("Penjelasan:");
            Console.WriteLine("- Console.Write()    : Menampilkan teks TANPA berpindah baris baru.");
            Console.WriteLine("- Console.WriteLine(): Menampilkan teks DAN berpindah ke baris baru.\n");

            Console.WriteLine("Demo Console.Write():");
            Console.Write("Halo ");
            Console.Write("Dunia\n\n");

            Console.WriteLine("Demo Console.WriteLine():");
            Console.WriteLine("Halo");
            Console.WriteLine("Dunia");
        }

        // Latihan 2: Buat program yang meminta nama dan menampilkan sapaan
        private static void LatihanInputSapaan()
        {
            Console.WriteLine("=== LATIHAN 2: INPUT NAMA DAN SAPAAN ===");
            Console.Write("Masukkan Nama Anda : ");
            string nama = Console.ReadLine();

            Console.WriteLine($"Halo {nama}, selamat belajar C#!");
        }

        // Latihan 3: Buat program menghitung umur dari tahun lahir
        private static void LatihanHitungUmurTahunLahir()
        {
            Console.WriteLine("=== LATIHAN 3: HITUNG UMUR DARI TAHUN LAHIR ===");
            Console.Write("Masukkan Tahun Lahir Anda : ");
            int tahunLahir = Convert.ToInt32(Console.ReadLine());

            int tahunSekarang = DateTime.Now.Year;
            int umur = tahunSekarang - tahunLahir;

            Console.WriteLine($"\nTahun Sekarang : {tahunSekarang}");
            Console.WriteLine($"Umur Anda      : {umur} tahun");
        }
    }
}