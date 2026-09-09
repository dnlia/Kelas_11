using System;

namespace dataSiswa
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("*                         Data Siswa                       *");
            Console.WriteLine("************************************************************");
            Console.WriteLine();
            Console.WriteLine();

            Identitas idnts = new Identitas();
            MataPelajaran mapel = new MataPelajaran();
            Absen absen = new Absen();
            Nilai nilai = new Nilai();


            idnts.siswa();
            idnts.wali();
            idnts.sekolah();

            mapel.produktif();
            mapel.nonProduktif();

            absen.januari();
            absen.februari();
            absen.maret();
            absen.april();
            absen.mei();
            absen.juni();
            absen.juli();
            absen.agustus();
            absen.september();
            absen.oktober();
            absen.november();
            absen.desember();

            nilai.semester1();
            nilai.semester2();
            nilai.semester3();

        }
    }

    class Identitas
    {
        public void siswa()
        {
            Console.WriteLine("=============== DATA IDENTITAS ===============");
            Console.WriteLine();

            Console.WriteLine("---------- Identitas Siswa ----------");
            Console.WriteLine("NISN           : 1234567890");
            Console.WriteLine("Nama           : Dinda Aulia Nur Waqidiyah");
            Console.WriteLine("Kelas          : XI - Rekayasa Perangkat Lunak");
            Console.WriteLine("Tanggal Lahir  : 08 September 2009");
            Console.WriteLine("Jenis Kelamin  : Perempuan");
            Console.WriteLine("Alamat         : Jl. Kyai Subakir");
            Console.WriteLine("No. Telepon    : 0895801640802");
            Console.WriteLine();
        }

        public void wali()
        {
            Console.WriteLine("---------- Identitas Wali ----------");
            Console.WriteLine("Nama Wali    : Kim Nam Joon");
            Console.WriteLine("Pekerjaan    : Pegawai Negeri Sipil");
            Console.WriteLine("Alamat       : Jl. Kyai Subakir");
            Console.WriteLine("No. Telepon  : 081234567890");
            Console.WriteLine();
        }

        public void sekolah()
        {
            Console.WriteLine("---------- Riwayat Sekolah ----------");
            Console.WriteLine("Taman Kanak-kanak          : TK Dharma Wanita");
            Console.WriteLine("Sekolah Dasar              : SD Negeri Kragan");
            Console.WriteLine("Sekolah Menengah Pertama   : SMP Negeri 1 Gedangan");
            Console.WriteLine("Sekolah Menengah Kejuruan  : SMK Negeri 2 Buduran");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class MataPelajaran
    {
        public void produktif()
        {
            Console.WriteLine("=============== MATA PELAJARAN PRODUKTIF ===============");
            Console.WriteLine();

            Console.WriteLine("---------- Mata Pelajaran Produktif ----------");
            Console.WriteLine("1. Pemrograman");
            Console.WriteLine("2. Pemrograman Web");
            Console.WriteLine("3. Pemrograman Data");
            Console.WriteLine();
        }

        public void nonProduktif()
        {
            Console.WriteLine("---------- Mata Pelajaran Non-Produktif ----------");
            Console.WriteLine("1. Bahasa Indonesia");
            Console.WriteLine("2. Bahasa Inggris");
            Console.WriteLine("3. Bahasa Jepang");
            Console.WriteLine();
            Console.WriteLine();
        }

    }

    class Absen
    {
        public void januari()
        {
            Console.WriteLine("=============== DATA ABSENSI ===============");
            Console.WriteLine();

            Console.WriteLine("---------- Absensi Bulan Januari ----------");
            Console.WriteLine("Hadir   : 20 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void februari()
        {
            Console.WriteLine("---------- Absensi Bulan Februari ----------");
            Console.WriteLine("Hadir   : 18 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void maret()
        {
            Console.WriteLine("---------- Absensi Bulan Maret ----------");
            Console.WriteLine("Hadir   : 22 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void april()
        {
            Console.WriteLine("---------- Absensi Bulan April ----------");
            Console.WriteLine("Hadir   : 20 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void mei()
        {
            Console.WriteLine("---------- Absensi Bulan Mei ----------");
            Console.WriteLine("Hadir   : 21 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void juni()
        {
            Console.WriteLine("---------- Absensi Bulan Juni ----------");
            Console.WriteLine("Hadir   : 19 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void juli()
        {
            Console.WriteLine("---------- Absensi Bulan Juli ----------");
            Console.WriteLine("Hadir   : 20 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void agustus()
        {
            Console.WriteLine("---------- Absensi Bulan Agustus ----------");
            Console.WriteLine("Hadir   : 22 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }
        
        public void september()
        {
            Console.WriteLine("---------- Absensi Bulan September ----------");
            Console.WriteLine("Hadir   : 21 Hari");
            Console.WriteLine("Sakit   : 1 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void oktober()
        {
            Console.WriteLine("---------- Absensi Bulan Oktober ----------");
            Console.WriteLine("Hadir   : 20 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void november()
        {
            Console.WriteLine("---------- Absensi Bulan November ----------");
            Console.WriteLine("Hadir   : 21 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
        }

        public void desember()
        {
            Console.WriteLine("---------- Absensi Bulan Desember ----------");
            Console.WriteLine("Hadir   : 20 Hari");
            Console.WriteLine("Sakit   : 0 Hari");
            Console.WriteLine("Izin    : 0 Hari");
            Console.WriteLine("Alpa    : 0 Hari");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    
    class Nilai
    {
        public void semester1()
        {
            Console.WriteLine("=============== DATA NILAI ===============");
            Console.WriteLine();

            Console.WriteLine("---------- Nilai Semester 1 ----------");
            Console.WriteLine("Matematika         : 87");
            Console.WriteLine("Bahasa Indonesia   : 95");
            Console.WriteLine("Bahasa Inggris     : 88");
            Console.WriteLine("Bahasa Jerman      : 92");
            Console.WriteLine("Pemrograman        : 87");
            Console.WriteLine();
        }

        public void semester2()
        {
            Console.WriteLine("---------- Nilai Semester 2 ----------");
            Console.WriteLine("Matematika         : 90");
            Console.WriteLine("Bahasa Indonesia   : 93");
            Console.WriteLine("Bahasa Inggris     : 90");
            Console.WriteLine("Bahasa Jerman      : 90");
            Console.WriteLine("Pemrograman        : 90");
            Console.WriteLine();
        }

        public void semester3()
        {
            Console.WriteLine("---------- Nilai Semester 3 ----------");
            Console.WriteLine("Matematika         : 98");
            Console.WriteLine("Bahasa Indonesia   : 99");
            Console.WriteLine("Bahasa Inggris     : 98");
            Console.WriteLine("Bahasa Jerman      : 98");
            Console.WriteLine("Pemrograman        : 98");
            Console.WriteLine();
        }
    }
}