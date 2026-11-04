using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab11
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("     BAB 11: PERULANGAN (LOOPING) PADA C#         ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- MATERI PERULANGAN ---");
                Console.WriteLine(" 1. Materi 1: Pengertian Perulangan");
                Console.WriteLine(" 2. Materi 2: Perulangan for");
                Console.WriteLine(" 3. Materi 3: Perulangan while");
                Console.WriteLine(" 4. Materi 4: Perulangan do...while");
                Console.WriteLine(" 5. Materi 5: Perulangan foreach");
                Console.WriteLine(" 6. Materi 6: break dan continue");
                Console.WriteLine(" 7. Materi 7: Nested Loop");
                Console.WriteLine();
                Console.WriteLine("--- CONTOH PROGRAM ---");
                Console.WriteLine(" 8. Contoh 1: Pola Bintang");
                Console.WriteLine(" 9. Contoh 2: Tabel Perkalian");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine("10. Studi Kasus 1: Menampilkan Angka 1-100");
                Console.WriteLine("11. Studi Kasus 2: Menjumlahkan Bilangan 1-50");
                Console.WriteLine("12. Studi Kasus 3: Membuat Pola Segitiga Bintang");
                Console.WriteLine("13. Studi Kasus 4: Menampilkan Tabel Perkalian");
                Console.WriteLine();
                Console.WriteLine("--- MINI PROJECT ---");
                Console.WriteLine("14. Mini Project: Input Nama Jumlah Siswa");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine("15. Latihan 1: Hitung Faktorial");
                Console.WriteLine("16. Latihan 2: Cari Bilangan Genap 1-100");
                Console.WriteLine("17. Latihan 3: Pola Persegi (Nested Loop)");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-17): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        MateriPengertian();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        MateriFor();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        MateriWhile();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        MateriDoWhile();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        MateriForeach();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        MateriBreakContinue();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        MateriNestedLoop();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        ContohPolaBintang();
                        TahanLayar();
                        break;
                    case "9":
                        Console.Clear();
                        ContohTabelPerkalian();
                        TahanLayar();
                        break;
                    case "10":
                        Console.Clear();
                        StudiKasusAngka1Ke100();
                        TahanLayar();
                        break;
                    case "11":
                        Console.Clear();
                        StudiKasusJumlah1Ke50();
                        TahanLayar();
                        break;
                    case "12":
                        Console.Clear();
                        StudiKasusSegitigaBintang();
                        TahanLayar();
                        break;
                    case "13":
                        Console.Clear();
                        StudiKasusTabelPerkalian();
                        TahanLayar();
                        break;
                    case "14":
                        Console.Clear();
                        MiniProjectInputSiswa();
                        TahanLayar();
                        break;
                    case "15":
                        Console.Clear();
                        LatihanFaktorial();
                        TahanLayar();
                        break;
                    case "16":
                        Console.Clear();
                        LatihanGenap1Ke100();
                        TahanLayar();
                        break;
                    case "17":
                        Console.Clear();
                        LatihanPolaPersegi();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 11...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // MATERI 1 - 7 (SESUAI KODE MODUL BAB 11)
        // ----------------------------------------------------

        // Materi 1. Pengertian Perulangan
        private static void MateriPengertian()
        {
            Console.WriteLine("=== MATERI 1: PENGERTIAN PERULANGAN ===");
            Console.WriteLine("Perulangan adalah struktur kontrol yang menjalankan ");
            Console.WriteLine("blok kode secara berulang selama syarat tertentu terpenuhi.");
        }

        // Materi 2. Perulangan for
        private static void MateriFor()
        {
            Console.WriteLine("=== MATERI 2: PERULANGAN FOR ===");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Materi 3. Perulangan while
        private static void MateriWhile()
        {
            Console.WriteLine("=== MATERI 3: PERULANGAN WHILE ===");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // Materi 4. Perulangan do...while
        private static void MateriDoWhile()
        {
            Console.WriteLine("=== MATERI 4: PERULANGAN DO...WHILE ===");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }

        // Materi 5. Perulangan foreach
        private static void MateriForeach()
        {
            Console.WriteLine("=== MATERI 5: PERULANGAN FOREACH ===");
            string[] nama = { "Andi", "Budi", "Sinta" };
            foreach (string n in nama)
            {
                Console.WriteLine(n);
            }
        }

        // Materi 6. break dan continue
        private static void MateriBreakContinue()
        {
            Console.WriteLine("=== MATERI 6: BREAK DAN CONTINUE ===");
            Console.WriteLine("--- Contoh Break (Berhenti saat i == 5) ---");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--- Contoh Continue (Lewati saat i == 5) ---");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);
            }
        }

        // Materi 7. Nested Loop
        private static void MateriNestedLoop()
        {
            Console.WriteLine("=== MATERI 7: NESTED LOOP ===");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(i + "," + j + " ");
                }
                Console.WriteLine();
            }
        }

        // ----------------------------------------------------
        // CONTOH PROGRAM (SESUAI MODUL BAB 11)
        // ----------------------------------------------------

        // Contoh Program Pola Bintang
        private static void ContohPolaBintang()
        {
            Console.WriteLine("=== CONTOH PROGRAM POLA BINTANG ===");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        // Contoh Program Tabel Perkalian
        private static void ContohTabelPerkalian()
        {
            Console.WriteLine("=== CONTOH PROGRAM TABEL PERKALIAN ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI MODUL BAB 11)
        // ----------------------------------------------------

        // Studi Kasus 1: Menampilkan angka 1-100
        private static void StudiKasusAngka1Ke100()
        {
            Console.WriteLine("=== STUDI KASUS 1: MENAMPILKAN ANGKA 1-100 ===");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Studi Kasus 2: Menjumlahkan bilangan 1-50
        private static void StudiKasusJumlah1Ke50()
        {
            Console.WriteLine("=== STUDI KASUS 2: MENJUMLAHKAN BILANGAN 1-50 ===");
            int total = 0;
            for (int i = 1; i <= 50; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total penjumlahan 1 sampai 50 = {total}");
        }

        // Studi Kasus 3: Membuat pola segitiga bintang
        private static void StudiKasusSegitigaBintang()
        {
            Console.WriteLine("=== STUDI KASUS 3: POLA SEGITIGA BINTANG ===");
            Console.Write("Masukkan Tinggi Segitiga: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Studi Kasus 4: Menampilkan tabel perkalian
        private static void StudiKasusTabelPerkalian()
        {
            Console.WriteLine("=== STUDI KASUS 4: MENAMPILKAN TABEL PERKALIAN ===");
            Console.Write("Masukkan Angka Perkalian: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{angka} x {i} = {angka * i}");
            }
        }

        // ----------------------------------------------------
        // MINI PROJECT (SESUAI TEKS MODUL BAB 11)
        // ----------------------------------------------------
        private static void MiniProjectInputSiswa()
        {
            Console.WriteLine("=== MINI PROJECT BAB 11 ===");
            Console.Write("Masukkan jumlah siswa: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Nama siswa ke-{i}: ");
                string nama = Console.ReadLine();
            }
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI MODUL BAB 11)
        // ----------------------------------------------------

        // Latihan 1: Buat program menghitung faktorial
        private static void LatihanFaktorial()
        {
            Console.WriteLine("=== LATIHAN 1: MENGHITUNG FAKTORIAL ===");
            Console.Write("Masukkan Angka: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long faktorial = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine($"{n}! = {faktorial}");
        }

        // Latihan 2: Buat program mencari bilangan genap 1-100
        private static void LatihanGenap1Ke100()
        {
            Console.WriteLine("=== LATIHAN 2: BILANGAN GENAP 1-100 ===");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        // Latihan 3: Buat program menampilkan pola persegi menggunakan nested loop
        private static void LatihanPolaPersegi()
        {
            Console.WriteLine("=== LATIHAN 3: POLA PERSEGI (NESTED LOOP) ===");
            Console.Write("Masukkan Sisi Persegi: ");
            int sisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sisi; i++)
            {
                for (int j = 1; j <= sisi; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}