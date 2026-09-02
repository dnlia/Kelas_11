using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab2
    {
        public static void Jalankan()
        {
            bool kembali = false;

            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("        BAB 2: ALGORITMA DALAM PEMROGRAMAN        ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- CONTOH IMPLEMENTASI ---");
                Console.WriteLine(" 1. Menghitung Luas Persegi");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 2. Studi Kasus 1: Login Sederhana");
                Console.WriteLine(" 3. Studi Kasus 2: Menghitung Rata-Rata 3 Nilai");
                Console.WriteLine(" 4. Studi Kasus 3: Menentukan Bilangan Ganjil / Genap");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 5. Latihan 1: Algoritma Membuat Teh");
                Console.WriteLine(" 6. Latihan 2: Algoritma Menarik Uang di ATM");
                Console.WriteLine(" 7. Latihan 3: Menghitung Luas Segitiga");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-7): ");

                string subPilihan = Console.ReadLine();
                if (subPilihan == "0")
                {
                    kembali = true;
                    return;
                }

                switch (subPilihan)
                {
                    case "1":
                        Console.Clear();
                        ContohLuasPersegi();
                        break;
                    case "2":
                        Console.Clear();
                        StudiKasusLogin();
                        break;
                    case "3":
                        Console.Clear();
                        StudiKasusRataRata();
                        break;
                    case "4":
                        Console.Clear();
                        StudiKasusGanjilGenap();
                        break;
                    case "5":
                        Console.Clear();
                        LatihanMembuatTeh();
                        break;
                    case "6":
                        Console.Clear();
                        LatihanTarikUangATM();
                        break;
                    case "7":
                        Console.Clear();
                        LatihanLuasSegitiga();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                if (!kembali)
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 2...");
                    Console.ReadLine();
                }
            }
        }

        // ----------------------------------------------------
        //                CONTOH IMPLEMENTASI
        // ----------------------------------------------------
        private static void ContohLuasPersegi()
        {
            Console.WriteLine("=== CONTOH: MENGHITUNG LUAS PERSEGI ===");
            Console.Write("Masukkan sisi: ");
            int sisi = Convert.ToInt32(Console.ReadLine());
            int luas = sisi * sisi;
            Console.WriteLine("Luas = " + luas);
        }

        // ----------------------------------------------------
        //                    STUDI KASUS
        // ----------------------------------------------------

        // Studi Kasus 1: Login Sederhana
        private static void StudiKasusLogin()
        {
            Console.WriteLine("=== STUDI KASUS 1: LOGIN SEDERHANA ===");
            string usernameBenar = "admin";
            string passwordBenar = "123";

            Console.Write("Masukkan Username: ");
            string usernameInput = Console.ReadLine();

            Console.Write("Masukkan Password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == usernameBenar && passwordInput == passwordBenar)
            {
                Console.WriteLine("\nStatus: Login Berhasil! Selamat datang, " + usernameInput + ".");
            }
            else
            {
                Console.WriteLine("\nStatus: Login Gagal! Username atau Password salah.");
            }
        }

        // Studi Kasus 2: Menghitung Rata-rata Tiga Nilai
        private static void StudiKasusRataRata()
        {
            Console.WriteLine("=== STUDI KASUS 2: MENGHITUNG RATA-RATA 3 NILAI ===");
            Console.Write("Masukkan Nilai 1 : ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai 2 : ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai 3 : ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double rataRata = (n1 + n2 + n3) / 3.0;
            Console.WriteLine($"\nHasil Rata-rata = {rataRata:F2}");
        }

        // Studi Kasus 3: Menentukan Bilangan Ganjil atau Genap
        private static void StudiKasusGanjilGenap()
        {
            Console.WriteLine("=== STUDI KASUS 3: MENENTUKAN BILANGAN GANJIL / GENAP ===");
            Console.Write("Masukkan sebuah bilangan bulat: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine($"Angka {angka} adalah Bilangan GENAP.");
            }
            else
            {
                Console.WriteLine($"Angka {angka} adalah Bilangan GANJIL.");
            }
        }

        // ----------------------------------------------------
        //                       LATIHAN
        // ----------------------------------------------------

        // Latihan 1: Algoritma Membuat Teh
        private static void LatihanMembuatTeh()
        {
            Console.WriteLine("=== LATIHAN 1: ALGORITMA MEMBUAT TEH ===");
            Console.WriteLine("Urutan Langkah-Langkah (Algoritma):");
            Console.WriteLine("1. Didihkan air secukupnya.");
            Console.WriteLine("2. Siapkan gelas kosong.");
            Console.WriteLine("3. Masukkan 1 kantong teh celup ke dalam gelas.");
            Console.WriteLine("4. Masukkan 2 sendok gula pasir ke dalam gelas.");
            Console.WriteLine("5. Tuangkan air panas ke dalam gelas.");
            Console.WriteLine("6. Aduk hingga gula larut dan warna air berubah.");
            Console.WriteLine("7. Angkat kantong teh, teh hangat siap diminum.");
        }

        // Latihan 2: Algoritma Menarik Uang di ATM
        private static void LatihanTarikUangATM()
        {
            Console.WriteLine("=== LATIHAN 2: ALGORITMA MENARIK UANG DI ATM ===");
            Console.WriteLine("Urutan Langkah-Langkah (Algoritma):");
            Console.WriteLine("1. Datangi mesin ATM dan masukkan kartu ATM.");
            Console.WriteLine("2. Pilih Bahasa (misal: Bahasa Indonesia).");
            Console.WriteLine("3. Masukkan 6 Digit PIN ATM.");
            Console.WriteLine("4. Pilih menu 'Tarik Tunai'.");
            Console.WriteLine("5. Pilih atau ketik nominal uang yang ingin ditarik.");
            Console.WriteLine("6. Tunggu mesin memproses uang.");
            Console.WriteLine("7. Ambil uang tunai yang keluar dari mesin.");
            Console.WriteLine("8. Ambil struk dan kartu ATM kembali dari mesin.");
        }

        // Latihan 3: Menghitung Luas Segitiga
        private static void LatihanLuasSegitiga()
        {
            Console.WriteLine("=== LATIHAN 3: MENGHITUNG LUAS SEGITIGA ===");
            Console.Write("Masukkan Alas   : ");
            double alas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Tinggi : ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double luas = 0.5 * alas * tinggi;
            Console.WriteLine($"\nLuas Segitiga = {luas}");
        }
    }
}