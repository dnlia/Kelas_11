using System;
using System.Collections.Generic;
using System.Text;



namespace Tugas_1
{
    internal class Menu
    {

        Kalkulator kalku = new Kalkulator();
        BangunDatar datar = new BangunDatar();
        BangunRuang ruang = new BangunRuang();
        Zodiak zodiak = new Zodiak();

        public void TampilMenu()
        {
            int pilih;

            do
            {
                Console.Clear();
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("0. Keluar");
                Console.WriteLine();
                Console.Write("Pilih Nomor Menu : ");
                pilih = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (pilih)
                {
                    case 1:
                        MenuKalkulator();
                        break;

                    case 2:
                        MenuBangunDatar();
                        break;

                    case 3:
                        MenuBangunRuang();
                        break;

                    case 4:
                        MenuZodiak();
                        break;

                    case 0:
                        Console.WriteLine("Terima Kasih...");
                        break;

                    default:
                        Console.WriteLine("Menu Tidak Ada");
                        break;
                }

                if (pilih != 0)
                {
                    Console.WriteLine("\nTekan Enter...");
                    Console.ReadLine();
                }

            } while (pilih != 0);
        }

        void MenuKalkulator()
        {
            Console.WriteLine("========== KALKULATOR ==========");
            Console.WriteLine();
            Console.Write("Angka Pertama : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Angka Kedua : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*** HASIL ***");
            Console.WriteLine("Tambah = " + kalku.Tambah(a, b));
            Console.WriteLine("Kurang = " + kalku.Kurang(a, b));
            Console.WriteLine("Kali = " + kalku.Kali(a, b));
            Console.WriteLine("Bagi = " + kalku.Bagi(a, b));
        }

        void MenuBangunDatar()
        {
            Console.WriteLine("========== BANGUN DATAR ==========");
            Console.WriteLine();
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine();
            Console.Write("Pilih : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (p == 1)
            {
                Console.WriteLine("========== Persegi ==========");
                Console.Write("Sisi : ");
                double s = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Luas = " + datar.LuasPersegi(s));
                Console.WriteLine("Keliling = " + datar.KelilingPersegi(s));
            }
            else if (p == 2)
            {
                Console.WriteLine("========== Lingkaran ==========");
                Console.Write("Jari-jari : ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Luas = " + datar.LuasLingkaran(r));
                Console.WriteLine("Keliling = " + datar.KelilingLingkaran(r));
            }
        }

        void MenuBangunRuang()
        {
            Console.WriteLine("========== BANGUN RUANG ==========");
            Console.WriteLine();
            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Bola");
            Console.WriteLine();
            Console.Write("Pilih : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (p == 1)
            {
                Console.WriteLine("========== Kubus ==========");
                Console.Write("Sisi : ");
                double s = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Luas Permukaan = " + ruang.LuasKubus(s));
                Console.WriteLine("Volume = " + ruang.VolumeKubus(s));
            }
            else if (p == 2)
            {
                Console.WriteLine("========== Bola ==========");
                Console.Write("Jari-jari : ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Luas Permukaan = " + ruang.LuasBola(r));
                Console.WriteLine("Volume = " + ruang.VolumeBola(r));
            }
        }

        void MenuZodiak()
        {
            Console.WriteLine("========== ZODIAK ==========");
            Console.WriteLine();
            Console.Write("Tanggal Lahir : ");
            int tgl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bulan Lahir : ");
            int bln = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zodiak Anda : " + zodiak.CekZodiak(tgl, bln));
        }
    }

}
