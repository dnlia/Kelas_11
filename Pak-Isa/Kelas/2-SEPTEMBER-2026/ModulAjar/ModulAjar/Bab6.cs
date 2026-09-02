using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab6
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("       BAB 6: STRUKTUR DASAR PROGRAM C#           ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- CONTOH IMPLEMENTASI ---");
                Console.WriteLine(" 1. Struktur Dasar Program C# (Hello World)");
                Console.WriteLine(" 2. Contoh Input dan Output");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 3. Studi Kasus 1: Menampilkan Nama Sekolah");
                Console.WriteLine(" 4. Studi Kasus 2: Input Nama & Sapaan Pengguna");
                Console.WriteLine(" 5. Studi Kasus 3: Menampilkan 3 Baris Informasi");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 6. Latihan 1: Fungsi 'using System'");
                Console.WriteLine(" 7. Latihan 2: Fungsi 'Main()'");
                Console.WriteLine(" 8. Latihan 3: Perbedaan Write() dan WriteLine()");
                Console.WriteLine(" 9. Latihan 4: Perbaikan Kesalahan Sintaks");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-9): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Langsung kembali ke Program.cs secara instan

                    case "1":
                        Console.Clear();
                        ContohStrukturDasar();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        ContohInputOutput();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        StudiKasusNamaSekolah();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        StudiKasusSapaan();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        StudiKasusTigaBaris();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        LatihanUsingSystem();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        LatihanMain();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        LatihanWriteVsWriteLine();
                        TahanLayar();
                        break;
                    case "9":
                        Console.Clear();
                        LatihanPerbaikanSintaks();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 6...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // CONTOH IMPLEMENTASI (SESUAI MODUL BAB 6)
        // ----------------------------------------------------
        private static void ContohStrukturDasar()
        {
            Console.WriteLine("=== CONTOH 1: STRUKTUR DASAR PROGRAM C# ===");
            Console.WriteLine("Kode Program:");
            Console.WriteLine("using System;");
            Console.WriteLine("namespace BelajarCSharp");
            Console.WriteLine("{");
            Console.WriteLine("    class Program");
            Console.WriteLine("    {");
            Console.WriteLine("        static void Main(string[] args)");
            Console.WriteLine("        {");
            Console.WriteLine("            Console.WriteLine(\"Hello World\");");
            Console.WriteLine("        }");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine("\nHasil Output:");
            Console.WriteLine("Hello World");
        }

        private static void ContohInputOutput()
        {
            Console.WriteLine("=== CONTOH 2: INPUT DAN OUTPUT ===");
            Console.Write("Masukkan nama: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Halo " + nama);
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI MODUL BAB 6)
        // ----------------------------------------------------
        private static void StudiKasusNamaSekolah()
        {
            Console.WriteLine("=== STUDI KASUS 1: NAMA SEKOLAH ===");
            Console.WriteLine("Nama Sekolah: SMKN 2 Buduran");
        }

        private static void StudiKasusSapaan()
        {
            Console.WriteLine("=== STUDI KASUS 2: INPUT NAMA & SAPAAN ===");
            Console.Write("Masukkan nama anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Halo " + nama + ", selamat belajar!");
        }

        private static void StudiKasusTigaBaris()
        {
            Console.WriteLine("=== STUDI KASUS 3: TIGA BARIS INFORMASI ===");
            Console.WriteLine("Baris 1: Bahasa C# dikembangkan oleh Microsoft.");
            Console.WriteLine("Baris 2: Pemrograman RPL berfokus pada kualitas perangkat lunak.");
            Console.WriteLine("Baris 3: Setiap pernyataan dalam C# diakhiri dengan titik koma (;).");
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI MODUL BAB 6)
        // ----------------------------------------------------
        private static void LatihanUsingSystem()
        {
            Console.WriteLine("=== LATIHAN 1: FUNGSI 'using System' ===");
            Console.WriteLine("Penjelasan:");
            Console.WriteLine("'using System;' berfungsi untuk mengimpor namespace System.");
            Console.WriteLine("Namespace ini berisi class dasar seperti 'Console'.");
        }

        private static void LatihanMain()
        {
            Console.WriteLine("=== LATIHAN 2: FUNGSI 'Main()' ===");
            Console.WriteLine("Penjelasan:");
            Console.WriteLine("Method 'Main()' adalah titik awal eksekusi (entry point) program C#.");
        }

        private static void LatihanWriteVsWriteLine()
        {
            Console.WriteLine("=== LATIHAN 3: PERBEDAAN Write() DAN WriteLine() ===");
            Console.WriteLine("1. Console.Write()     : Menampilkan teks TANPA membuat baris baru.");
            Console.WriteLine("2. Console.WriteLine() : Menampilkan teks DENGAN membuat baris baru.");
        }

        private static void LatihanPerbaikanSintaks()
        {
            Console.WriteLine("=== LATIHAN 4: PERBAIKAN KESALAHAN SINTAKS ===");
            Console.WriteLine("Kode Salah : console.writeline(\"Hello World\")");
            Console.WriteLine("Kode Benar : Console.WriteLine(\"Hello World\");");
            Console.WriteLine("\nHasil Output:");
            Console.WriteLine("Hello World");
        }
    }
}