using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab1
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("   BAB 1: PENGENALAN PEMROGRAMAN KOMPUTER        ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- CONTOH PROGRAM PERTAMA ---");
                Console.WriteLine(" 1. Contoh Program Pertama & Penjelasan Kode");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN MODUL ---");
                Console.WriteLine(" 2. Latihan 1: Perbedaan Hardware dan Software");
                Console.WriteLine(" 3. Latihan 2: Lima Bahasa Pemrograman");
                Console.WriteLine(" 4. Latihan 3: Program Hello World C#");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-4): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        ContohProgramPertama();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        LatihanHardwareSoftware();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        LatihanBahasaPemrograman();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        LatihanHelloWorld();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 1...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // CONTOH PROGRAM PERTAMA (SESUAI MODUL BAB 1)
        // ----------------------------------------------------
        private static void ContohProgramPertama()
        {
            Console.WriteLine("=== CONTOH PROGRAM PERTAMA ===");
            Console.WriteLine("Kode Program:");
            Console.WriteLine("using System;");
            Console.WriteLine("class Program");
            Console.WriteLine("{");
            Console.WriteLine("    static void Main(string[] args)");
            Console.WriteLine("    {");
            Console.WriteLine("        Console.WriteLine(\"Hello World\");");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine("\nHasil Output:");
            Console.WriteLine("Hello World");

            Console.WriteLine("\n--- Penjelasan Kode ---");
            Console.WriteLine("• using System         : Memanggil pustaka System.");
            Console.WriteLine("• class Program        : Mendefinisikan kelas.");
            Console.WriteLine("• Main()               : Titik awal eksekusi program.");
            Console.WriteLine("• Console.WriteLine()  : Menampilkan teks ke layar.");
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI MODUL BAB 1)
        // ----------------------------------------------------
        private static void LatihanHardwareSoftware()
        {
            Console.WriteLine("=== LATIHAN 1: PERBEDAAN HARDWARE DAN SOFTWARE ===");
            Console.WriteLine("Penjelasan:");
            Console.WriteLine("1. Hardware (Perangkat Keras) : Komponen fisik komputer yang dapat dilihat");
            Console.WriteLine("                                dan disentuh secara langsung (cth: Keyboard, CPU).");
            Console.WriteLine("2. Software (Perangkat Lunak) : Kumpulan instruksi atau program elektronik yang");
            Console.WriteLine("                                menjalankan fungsi tertentu (cth: Windows, VS Code).");
        }

        private static void LatihanBahasaPemrograman()
        {
            Console.WriteLine("=== LATIHAN 2: 5 BAHASA PEMROGRAMAN ===");
            Console.WriteLine("Contoh 5 bahasa pemrograman:");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. Java");
            Console.WriteLine("3. Python");
            Console.WriteLine("4. C++");
            Console.WriteLine("5. JavaScript");
        }

        private static void LatihanHelloWorld()
        {
            Console.WriteLine("=== LATIHAN 3: PROGRAM HELLO WORLD C# ===");
            Console.WriteLine("Kode Program:");
            Console.WriteLine("using System;");
            Console.WriteLine("class Program");
            Console.WriteLine("{");
            Console.WriteLine("    static void Main(string[] args)");
            Console.WriteLine("    {");
            Console.WriteLine("        Console.WriteLine(\"Hello World\");");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine("\nHasil Output:");
            Console.WriteLine("Hello World");
        }
    }
}