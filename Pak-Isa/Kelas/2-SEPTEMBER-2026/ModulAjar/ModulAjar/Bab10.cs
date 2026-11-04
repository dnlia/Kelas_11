using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab10
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("      BAB 10: PERCABANGAN (SELECTION) PADA C#     ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- MATERI PERCABANGAN ---");
                Console.WriteLine(" 1. Materi 2: Percabangan if");
                Console.WriteLine(" 2. Materi 3: Percabangan if...else");
                Console.WriteLine(" 3. Materi 4: Percabangan else if");
                Console.WriteLine(" 4. Materi 5: Nested if");
                Console.WriteLine(" 5. Materi 6: Operator Ternary");
                Console.WriteLine(" 6. Materi 7: Switch");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 7. Studi Kasus 1: Menentukan Bilangan Genap atau Ganjil");
                Console.WriteLine(" 8. Studi Kasus 2: Menghitung Diskon Total Belanja");
                Console.WriteLine(" 9. Studi Kasus 3: Menentukan Kategori Nilai Siswa");
                Console.WriteLine();
                Console.WriteLine("--- MINI PROJECT ---");
                Console.WriteLine("10. Mini Project: Syarat Pembuatan KTP");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine("11. Latihan 1: Login Sederhana (Username & Password)");
                Console.WriteLine("12. Latihan 2: Menentukan Hari (Switch 1-7)");
                Console.WriteLine("13. Latihan 3: Menentukan Nilai (A, B, C, D)");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-13): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        MateriIf();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        MateriIfElse();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        MateriElseIf();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        MateriNestedIf();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        MateriTernary();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        MateriSwitch();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        StudiKasusGenapGanjil();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        StudiKasusDiskonBelanja();
                        TahanLayar();
                        break;
                    case "9":
                        Console.Clear();
                        StudiKasusKategoriNilai();
                        TahanLayar();
                        break;
                    case "10":
                        Console.Clear();
                        MiniProjectKTP();
                        TahanLayar();
                        break;
                    case "11":
                        Console.Clear();
                        LatihanLoginSederhana();
                        TahanLayar();
                        break;
                    case "12":
                        Console.Clear();
                        LatihanHariSwitch();
                        TahanLayar();
                        break;
                    case "13":
                        Console.Clear();
                        LatihanNilaiABCD();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 10...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // MATERI 2 - 7 (SESUAI TEKS & KODE MODUL)
        // ----------------------------------------------------

        // Materi 2. Percabangan if
        private static void MateriIf()
        {
            Console.WriteLine("=== MATERI 2: PERCABANGAN IF ===");
            Console.Write("Masukkan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Lulus");
            }
        }

        // Materi 3. Percabangan if...else
        private static void MateriIfElse()
        {
            Console.WriteLine("=== MATERI 3: PERCABANGAN IF...ELSE ===");
            Console.Write("Masukkan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Lulus");
            }
            else
            {
                Console.WriteLine("Tidak Lulus");
            }
        }

        // Materi 4. Percabangan else if
        private static void MateriElseIf()
        {
            Console.WriteLine("=== MATERI 4: PERCABANGAN ELSE IF ===");
            Console.Write("Masukkan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 90)
                Console.WriteLine("A");
            else if (nilai >= 80)
                Console.WriteLine("B");
            else if (nilai >= 70)
                Console.WriteLine("C");
            else
                Console.WriteLine("D");
        }

        // Materi 5. Nested if
        private static void MateriNestedIf()
        {
            Console.WriteLine("=== MATERI 5: NESTED IF ===");
            Console.Write("Masukkan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 75)
            {
                if (nilai >= 90)
                    Console.WriteLine("Predikat A");
            }
        }

        // Materi 6. Operator Ternary
        private static void MateriTernary()
        {
            Console.WriteLine("=== MATERI 6: OPERATOR TERNARY ===");
            Console.Write("Masukkan Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            string hasil = nilai >= 75 ? "Lulus" : "Tidak Lulus";
            Console.WriteLine(hasil);
        }

        // Materi 7. Switch
        private static void MateriSwitch()
        {
            Console.WriteLine("=== MATERI 7: SWITCH ===");
            Console.Write("Pilih Menu (1-3): ");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Data Siswa");
                    break;
                case 2:
                    Console.WriteLine("Data Guru");
                    break;
                case 3:
                    Console.WriteLine("Keluar");
                    break;
                default:
                    Console.WriteLine("Menu tidak tersedia");
                    break;
            }
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI PERINTAH MODUL)
        // ----------------------------------------------------

        // Studi Kasus 1: Menentukan bilangan ganjil atau genap
        private static void StudiKasusGenapGanjil()
        {
            Console.WriteLine("=== STUDI KASUS 1: BILANGAN GANJIL ATAU GENAP ===");
            Console.Write("Masukkan Angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine("Hasil: Bilangan Genap");
            }
            else
            {
                Console.WriteLine("Hasil: Bilangan Ganjil");
            }
        }

        // Studi Kasus 2: Menghitung diskon berdasarkan total belanja
        private static void StudiKasusDiskonBelanja()
        {
            Console.WriteLine("=== STUDI KASUS 2: HITUNG DISKON BELANJA ===");
            Console.Write("Masukkan Total Belanja (Rp): ");
            double totalBelanja = Convert.ToDouble(Console.ReadLine());

            double diskon = 0;
            if (totalBelanja >= 100000)
            {
                diskon = 0.10 * totalBelanja; // Diskon 10%
            }
            else if (totalBelanja >= 50000)
            {
                diskon = 0.05 * totalBelanja; // Diskon 5%
            }

            double totalBayar = totalBelanja - diskon;
            Console.WriteLine($"Diskon     : Rp {diskon}");
            Console.WriteLine($"Total Bayar: Rp {totalBayar}");
        }

        // Studi Kasus 3: Menentukan kategori nilai siswa
        private static void StudiKasusKategoriNilai()
        {
            Console.WriteLine("=== STUDI KASUS 3: KATEGORI NILAI SISWA ===");
            Console.Write("Masukkan Nilai Siswa (0-100): ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 85)
            {
                Console.WriteLine("Kategori: Sangat Baik");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Kategori: Baik");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Kategori: Cukup");
            }
            else
            {
                Console.WriteLine("Kategori: Perlu Bimbingan");
            }
        }

        // ----------------------------------------------------
        // MINI PROJECT (SESUAI TEKS MODUL)
        // ----------------------------------------------------
        private static void MiniProjectKTP()
        {
            Console.WriteLine("=== MINI PROJECT: SYARAT PEMBUATAN KTP ===");
            Console.Write("Masukkan Umur: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            if (umur >= 17)
                Console.WriteLine("Boleh membuat KTP");
            else
                Console.WriteLine("Belum memenuhi syarat");
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI PERINTAH MODUL)
        // ----------------------------------------------------

        // Latihan 1: Program login sederhana menggunakan username dan password
        private static void LatihanLoginSederhana()
        {
            Console.WriteLine("=== LATIHAN 1: LOGIN SEDERHANA ===");
            Console.Write("Masukkan Username : ");
            string username = Console.ReadLine();
            Console.Write("Masukkan Password : ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "123")
            {
                Console.WriteLine("\nLogin Berhasil! Selamat datang, Admin.");
            }
            else
            {
                Console.WriteLine("\nLogin Gagal! Username atau Password salah.");
            }
        }

        // Latihan 2: Program menentukan hari berdasarkan nomor 1-7 dengan switch
        private static void LatihanHariSwitch()
        {
            Console.WriteLine("=== LATIHAN 2: MENENTUKAN HARI DENGAN SWITCH ===");
            Console.Write("Masukkan Nomor Hari (1-7): ");
            int noHari = Convert.ToInt32(Console.ReadLine());

            switch (noHari)
            {
                case 1:
                    Console.WriteLine("Hari: Senin");
                    break;
                case 2:
                    Console.WriteLine("Hari: Selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari: Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari: Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari: Jumat");
                    break;
                case 6:
                    Console.WriteLine("Hari: Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari: Minggu");
                    break;
                default:
                    Console.WriteLine("Nomor hari tidak valid! Masukkan angka 1 sampai 7.");
                    break;
            }
        }

        // Latihan 3: Program menentukan nilai A, B, C, D
        private static void LatihanNilaiABCD()
        {
            Console.WriteLine("=== LATIHAN 3: MENENTUKAN NILAI A, B, C, D ===");
            Console.Write("Masukkan Nilai (0-100): ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 85)
            {
                Console.WriteLine("Nilai: A");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Nilai: B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Nilai: C");
            }
            else
            {
                Console.WriteLine("Nilai: D");
            }
        }
    }
}