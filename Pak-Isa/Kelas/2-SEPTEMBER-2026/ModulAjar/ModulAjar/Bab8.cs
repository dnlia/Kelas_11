using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab8
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("          BAB 8: OPERATOR DALAM C#                ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 1. Studi Kasus 1: Hitung Total Belanja 3 Barang");
                Console.WriteLine(" 2. Studi Kasus 2: Penentuan Kelulusan Siswa");
                Console.WriteLine(" 3. Studi Kasus 3: Hitung Sisa Pembagian (Modulus)");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 4. Latihan 1: Hitung Luas Persegi Panjang");
                Console.WriteLine(" 5. Latihan 2: Hitung Rata-Rata 3 Nilai");
                Console.WriteLine(" 6. Latihan 3: Tentukan Bilangan Genap atau Ganjil");
                Console.WriteLine();
                Console.WriteLine("--- MINI PROJECT ---");
                Console.WriteLine(" 7. Mini Project: Menghitung Total Belanja Barang");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-7): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        StudiKasusTotalTigaBarang();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        StudiKasusKelulusanSiswa();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        StudiKasusModulus();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        LatihanLuasPersegiPanjang();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        LatihanRataRata();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        LatihanGenapGanjil();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        MiniProjectKasir();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 8...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        //         STUDI KASUS (SESUAI MODUL BAB 8)
        // ----------------------------------------------------

        // Studi Kasus 1: Hitung total belanja tiga barang
        private static void StudiKasusTotalTigaBarang()
        {
            Console.WriteLine("=== STUDI KASUS 1: HITUNG TOTAL BELANJA 3 BARANG ===");
            Console.Write("Masukkan Harga Barang 1 : ");
            double barang1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Harga Barang 2 : ");
            double barang2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Harga Barang 3 : ");
            double barang3 = Convert.ToDouble(Console.ReadLine());

            double total = barang1 + barang2 + barang3;
            Console.WriteLine("\nTotal Belanja 3 Barang = " + total);
        }

        // Studi Kasus 2: Tentukan apakah siswa lulus berdasarkan nilai
        private static void StudiKasusKelulusanSiswa()
        {
            Console.WriteLine("=== STUDI KASUS 2: PENENTUAN KELULUSAN SISWA ===");
            Console.Write("Masukkan Nilai Ujian : ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Persentase Absensi (0-100) : ");
            int absensi = Convert.ToInt32(Console.ReadLine());

            // Pengecekan syarat kelulusan
            if (nilai >= 75 && absensi >= 80)
            {
                Console.WriteLine("\nHasil: Siswa dinyatakan Lulus");
            }
            else
            {
                Console.WriteLine("\nHasil: Siswa dinyatakan Tidak Lulus");
            }
        }

        // Studi Kasus 3: Hitung sisa pembagian menggunakan operator modulus
        private static void StudiKasusModulus()
        {
            Console.WriteLine("=== STUDI KASUS 3: HITUNG SISA PEMBAGIAN (MODULUS) ===");
            Console.Write("Masukkan Angka Pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Pembagi : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sisa = a % b;
            Console.WriteLine($"\nHasil {a} % {b} (Sisa Pembagian) = " + sisa);
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI MODUL BAB 8)
        // ----------------------------------------------------

        // Latihan 1: Buat program menghitung luas persegi panjang
        private static void LatihanLuasPersegiPanjang()
        {
            Console.WriteLine("=== LATIHAN 1: LUAS PERSEGI PANJANG ===");
            Console.Write("Masukkan Panjang : ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar   : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine("\nLuas Persegi Panjang = " + luas);
        }

        // Latihan 2: Buat program menghitung rata-rata tiga nilai
        private static void LatihanRataRata()
        {
            Console.WriteLine("=== LATIHAN 2: RATA-RATA TIGA NILAI ===");
            Console.Write("Masukkan Nilai 1 : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai 2 : ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai 3 : ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double rataRata = (n1 + n2 + n3) / 3.0;
            Console.WriteLine("\nRata-Rata Nilai = " + rataRata);
        }

        // Latihan 3: Buat program menentukan bilangan genap atau ganjil
        private static void LatihanGenapGanjil()
        {
            Console.WriteLine("=== LATIHAN 3: BILANGAN GENAP ATAU GANJIL ===");
            Console.Write("Masukkan Angka : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine("\nKeterangan: Bilangan Genap");
            }
            else
            {
                Console.WriteLine("\nKeterangan: Bilangan Ganjil");
            }
        }

        // ----------------------------------------------------
        // MINI PROJECT (SESUAI MODUL BAB 8)
        // ----------------------------------------------------
        private static void MiniProjectKasir()
        {
            Console.WriteLine("=== MINI PROJECT BAB 8 ===");
            Console.Write("Harga Barang: ");
            double harga = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            double total = harga * jumlah;
            Console.WriteLine("Total = " + total);
        }
    }
}