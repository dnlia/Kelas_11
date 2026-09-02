using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab5
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("     BAB 5: INSTALASI VISUAL STUDIO DAN .NET      ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- LATIHAN MODUL ---");
                Console.WriteLine(" 1. Latihan: Proyek BelajarCSharp (Cetak Nama)");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-1): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Clear();
                        LatihanBelajarCSharp();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 5...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // LATIHAN SESUAI MODUL BAB 5
        // ----------------------------------------------------
        private static void LatihanBelajarCSharp()
        {
            Console.WriteLine("=== LATIHAN BAB 5: PROYEK BelajarCSharp ===");
            Console.Write("Masukkan Nama Anda: ");
            string nama = Console.ReadLine();

            Console.WriteLine();
            // Mengubah 'Halo Dunia!' menjadi nama sesuai petunjuk modul
            Console.WriteLine("Halo " + nama + "!");
        }
    }
}