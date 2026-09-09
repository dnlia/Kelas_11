using System;

namespace Jadwal
{
    class Home()
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                JADWAL PELAJARAN XI RPL - 2026           ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine();

            Senin day1 = new Senin();
            Selasa day2 = new Selasa();
            Rabu day3 = new Rabu();

            day1.Sesi1();
            day1.Sesi2();
            day1.Sesi3();

            day2.Sesi1();
            day2.Sesi2();
            day2.Sesi3();

            day3.Sesi1();
            day3.Sesi2();
            day3.Sesi3();

            Kamis.Sesi1();
            Kamis.Sesi2();
            Kamis.Sesi3();

            Jumat.Sesi1();
            Jumat.Sesi2();
            Jumat.Sesi3();

        }
    }

    class Senin()
    {
        public void Sesi1()
        {
            Console.WriteLine("================= HARI SENIN =================");

            Console.WriteLine("-------- Sesi 1 --------");
            Console.WriteLine("Jam Ke 0: Upacara");
            Console.WriteLine("Jam Ke 1: Bahasa Jepang");
            Console.WriteLine("Jam Ke 2: Bahasa Jepang");
            Console.WriteLine("Jam Ke 3: Bahasa Inggris");
            Console.WriteLine("Jam Ke 4: Bahasa Inggris");
            Console.WriteLine("Waktunya Istirahat");
            Console.WriteLine();
        }

        public void Sesi2()
        {
            Console.WriteLine("-------- Sesi 2 --------");
            Console.WriteLine("Jam Ke 5: Matematika");
            Console.WriteLine("Jam Ke 6: Matematika");
            Console.WriteLine("Jam Ke 7: Matematika");
            Console.WriteLine("Waktunya Istirahat, Sholat dan MBG");
            Console.WriteLine();
        }

        public void Sesi3()
        {
            Console.WriteLine("-------- Sesi 3 --------");
            Console.WriteLine("Jam Ke 8: Coding");
            Console.WriteLine("Jam Ke 9: Coding");
            Console.WriteLine("Jam Ke 10: Coding");
            Console.WriteLine("Jam Ke 11: Coding");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Selasa()
    {
        public void Sesi1()
        {
            Console.WriteLine("================= HARI SELASA =================");

            Console.WriteLine("-------- Sesi 1 --------");
            Console.WriteLine("Jam Ke 1: KIK");
            Console.WriteLine("Jam Ke 2: KIK");
            Console.WriteLine("Jam Ke 3: Olahraga");
            Console.WriteLine("Jam Ke 4: Olahraga");
            Console.WriteLine("Waktunya Istirahat");
            Console.WriteLine();
        }

        public void Sesi2()
        {
            Console.WriteLine("-------- Sesi 2 --------");
            Console.WriteLine("Jam Ke 5: Bahasa Indonesia");
            Console.WriteLine("Jam Ke 6: Bahasa Indonesia");
            Console.WriteLine("Jam Ke 7: Bahasa Indonesia");
            Console.WriteLine("Jam Ke 8: Coding");
            Console.WriteLine("Waktunya Istirahat, Sholat dan MBG ");
            Console.WriteLine();
        }

        public void Sesi3()
        {
            Console.WriteLine("-------- Sesi 3 --------");
            Console.WriteLine("Jam Ke 9: Coding");
            Console.WriteLine("Jam Ke 10: Coding");
            Console.WriteLine("Jam Ke 11: Coding");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Rabu()
    {
        public void Sesi1()
        {
            Console.WriteLine("================= HARI RABU =================");

            Console.WriteLine("-------- Sesi 1 --------");
            Console.WriteLine("Jam Ke 1: Coding");
            Console.WriteLine("Jam Ke 2: Coding");
            Console.WriteLine("Jam Ke 3: Coding");
            Console.WriteLine("Jam Ke 4: Coding");
            Console.WriteLine("Waktunya Istirahat");
            Console.WriteLine();
        }

        public void Sesi2()
        {
            Console.WriteLine("-------- Sesi 2 --------");
            Console.WriteLine("Jam Ke 5: Coding");
            Console.WriteLine("Jam Ke 6: Coding");
            Console.WriteLine("Jam Ke 7: Coding");
            Console.WriteLine("Jam Ke 8: Coding");
            Console.WriteLine("Waktunya Istirahat, Sholat, dan MBG");
            Console.WriteLine();
        }

        public void Sesi3()
        {
            Console.WriteLine("-------- Sesi 3 --------");
            Console.WriteLine("Jam Ke 9: Coding");
            Console.WriteLine("Jam Ke 10: Coding");
            Console.WriteLine("Jam Ke 11: BK");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Kamis()
    {
        public static void Sesi1()
        {
            Console.WriteLine("================= HARI KAMIS =================");

            Console.WriteLine("-------- Sesi 1 --------");
            Console.WriteLine("Jam Ke 1: Bahasa Jerman");
            Console.WriteLine("Jam Ke 2: Bahasa Jerman");
            Console.WriteLine("Jam Ke 3: Bahasa Jawa");
            Console.WriteLine("Jam Ke 4: Bahasa Jawa");
            Console.WriteLine("Waktunya Istirahat");
            Console.WriteLine();
        }

        public static void Sesi2()
        {
            Console.WriteLine("-------- Sesi 2 --------");
            Console.WriteLine("Jam Ke 5: KIK");
            Console.WriteLine("Jam Ke 6: KIK");
            Console.WriteLine("Jam Ke 7: KIK");
            Console.WriteLine("Jam Ke 8: PAI");
            Console.WriteLine("Waktunya Istirahat, Sholat dan MBG");
            Console.WriteLine();
        }

        public static void Sesi3()
        {
            Console.WriteLine("-------- Sesi 3 --------");
            Console.WriteLine("Jam Ke 9: PAI");
            Console.WriteLine("Jam Ke 10: PAI");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Jumat()
    {
        public static void Sesi1()
        {
            Console.WriteLine("================= HARI JUM'AT =================");

            Console.WriteLine("-------- Sesi 1 --------");
            Console.WriteLine("Jam Ke 0: Senam / Istighosah / Jum'at Bersih");
            Console.WriteLine("Jam Ke 1: Bahasa Inggris");
            Console.WriteLine("Jam Ke 2: Bahasa Inggris");
            Console.WriteLine("Jam Ke 3: Sejarah");
            Console.WriteLine("Waktunya Istirahat dan MBG");
            Console.WriteLine();
        }

        public static void Sesi2()
        {
            Console.WriteLine("-------- Sesi 2 --------");
            Console.WriteLine("Jam Ke 4: Sejarah");
            Console.WriteLine("Jam Ke 5: Pendidikan Pancasila");
            Console.WriteLine("Jam Ke 6: Pendidikan Pancasila");
            Console.WriteLine("Waktunya Istirahat dan Sholat");
            Console.WriteLine();
        }

        public static void Sesi3()
        {
            Console.WriteLine("-------- Sesi 3 --------");
            Console.WriteLine("Waktu Keputrian atau Ekstra Pramuka Wajib");
            Console.WriteLine("Waktunya Pulang");
        }
    }

}