using ModulAjar;
using System;

namespace ModulAjarRPL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jalan = true;

            while (jalan)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("         MODUL AJAR DASAR PEMROGRAMAN C#          ");
                Console.WriteLine("==================================================");
                Console.WriteLine("Pilih Bab/Item yang ingin dijalankan:");
                Console.WriteLine(" 1. Bab 1 : Pengenalan Pemrograman");
                Console.WriteLine(" 2. Bab 2 : Algoritma Pemrograman");
                Console.WriteLine(" 3. Bab 5 : Visual Studio & .NET");
                Console.WriteLine(" 4. Bab 6 : Struktur Dasar C#");
                Console.WriteLine(" 5. Bab 8 : Operator");
                Console.WriteLine(" 6. Bab 9 : Input & Output");
                Console.WriteLine(" 7. Bab 10: Percabangan");
                Console.WriteLine(" 8. Bab 11: Perulangan");
                Console.WriteLine(" 9. Bab 12: Array & Koleksi");
                Console.WriteLine("10. Bab 13: Method (Fungsi)");
                Console.WriteLine("11. Bab 14: Pengenalan OOP");
                Console.WriteLine(" 0. Keluar Aplikasi");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-14): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        Console.Clear();
                        Bab1.Jalankan();
                        break;
                    case "2":
                        Console.Clear();
                        Bab2.Jalankan();
                        break;
                    case "3":
                        Console.Clear();
                        Bab5.Jalankan();
                        break;
                    case "4":
                        Console.Clear();
                        Bab6.Jalankan();
                        break;
                    case "5":
                        Console.Clear();
                        Bab8.Jalankan();
                        break;
                    case "6":
                        Console.Clear();
                        Bab9.Jalankan();
                        break;
                    case "7":
                        Console.Clear();
                        Bab10.Jalankan();
                        break;
                    case "8":
                        Console.Clear();
                        Bab11.Jalankan();
                        break;
                    case "9":
                        Console.Clear();
                        Bab12.Jalankan();
                        break;
                    case "10":
                        Console.Clear();
                        Bab13.Jalankan();
                        break;
                    case "11":
                        Console.Clear();
                        Bab14.Jalankan();
                        break;

                    case "0":
                        jalan = false;
                        Console.WriteLine("Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }
    }
}