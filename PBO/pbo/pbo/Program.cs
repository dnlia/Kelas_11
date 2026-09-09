using System;
using System.Security.Cryptography.X509Certificates;

namespace Matematika
{
    class Home
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator kal = new Kalkulator();
            BangunDatar BDatar = new BangunDatar();
            BangunRuang BRuang = new BangunRuang();


            kal.penjumlahan();
            BangunDatar.luasLingkaran();
            BRuang.volumeTabung();
        }
    }

    class Kalkulator
    {
        public void penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
           
        }

        public void pengurangan()
        {
            Console.WriteLine("pengurangan");
        }

        public void perkalian()
        {
            Console.WriteLine("perkalian");
        }

        public void pembagian()
        {
            Console.WriteLine("pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void kelilingLingkran()
        {
            Console.WriteLine("Kelliling Lingkaran");
        }

        public static void luasPersegiPanjang()
        {
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void luasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void volumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void volumePiramida()
        {
            Console.WriteLine("Volume Piramida");
        }
    }
}