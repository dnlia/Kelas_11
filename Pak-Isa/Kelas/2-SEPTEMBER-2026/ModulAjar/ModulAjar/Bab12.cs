using System;
using System.Collections.Generic;
using System.Text;

namespace ModulAjar
{
    public class Bab12
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("    BAB 12: ARRAY DAN KOLEKSI DASAR PADA C#       ");
                Console.WriteLine("==================================================");
                Console.WriteLine("--- MATERI ---");
                Console.WriteLine(" 1. Materi 1: Pengertian & Operasi Array");
                Console.WriteLine(" 2. Materi 2: Koleksi Dinamis List<T>");
                Console.WriteLine();
                Console.WriteLine("--- STUDI KASUS ---");
                Console.WriteLine(" 3. Studi Kasus 1: Menyimpan Nilai 10 Siswa");
                Console.WriteLine(" 4. Studi Kasus 2: Menghitung Nilai Tertinggi dan Rata-Rata");
                Console.WriteLine(" 5. Studi Kasus 3: Mengelola Daftar Nama dengan List<T>");
                Console.WriteLine();
                Console.WriteLine("--- MINI PROJECT ---");
                Console.WriteLine(" 6. Mini Project: Menghitung Rata-Rata Array Nilai");
                Console.WriteLine();
                Console.WriteLine("--- LATIHAN ---");
                Console.WriteLine(" 7. Latihan 1: Mencari Nilai Terbesar dalam Array");
                Console.WriteLine(" 8. Latihan 2: Menghitung Jumlah Bilangan Genap");
                Console.WriteLine(" 9. Latihan 3: Aplikasi Daftar Nama Menggunakan List<T>");
                Console.WriteLine();
                Console.WriteLine(" 0. Kembali ke Menu Utama");
                Console.WriteLine("==================================================");
                Console.Write("Ketik Angka Pilihan (0-9): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "0":
                        return; // Kembali ke Program.cs

                    case "1":
                        Console.Clear();
                        MateriArray();
                        TahanLayar();
                        break;
                    case "2":
                        Console.Clear();
                        MateriList();
                        TahanLayar();
                        break;
                    case "3":
                        Console.Clear();
                        StudiKasusNilai10Siswa();
                        TahanLayar();
                        break;
                    case "4":
                        Console.Clear();
                        StudiKasusNilaiTertinggiDanRataRata();
                        TahanLayar();
                        break;
                    case "5":
                        Console.Clear();
                        StudiKasusKelolaListNama();
                        TahanLayar();
                        break;
                    case "6":
                        Console.Clear();
                        MiniProjectRataRataArray();
                        TahanLayar();
                        break;
                    case "7":
                        Console.Clear();
                        LatihanNilaiTerbesar();
                        TahanLayar();
                        break;
                    case "8":
                        Console.Clear();
                        LatihanJumlahBilanganGenap();
                        TahanLayar();
                        break;
                    case "9":
                        Console.Clear();
                        LatihanAplikasiDaftarNama();
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
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Bab 12...");
            Console.ReadLine();
        }

        // ----------------------------------------------------
        // MATERI 1 - 2 (SESUAI KODE MODUL BAB 12)
        // ----------------------------------------------------

        // Materi 1. Pengertian Array
        private static void MateriArray()
        {
            Console.WriteLine("=== MATERI 1: PENGERTIAN & OPERASI ARRAY ===");

            // Deklarasi dan Inisialisasi Array
            int[] nilai = { 80, 85, 90, 75, 88 };
            string[] nama = { "Andi", "Budi", "Sinta" };

            Console.WriteLine("--- Mengakses Elemen Array ---");
            Console.WriteLine(nilai[0]);
            Console.WriteLine(nama[1]);

            Console.WriteLine("\n--- Mengubah Nilai Array ---");
            nilai[2] = 95;
            Console.WriteLine(nilai[2]);

            Console.WriteLine("\n--- Perulangan for pada Array ---");
            for (int i = 0; i < nilai.Length; i++)
            {
                Console.WriteLine(nilai[i]);
            }

            Console.WriteLine("\n--- Perulangan foreach pada Array ---");
            foreach (string n in nama)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n--- Array Dua Dimensi ---");
            int[,] matriks =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine($"Matriks [1,2]: {matriks[1, 2]}");
        }

        // Materi 2. List<T>
        private static void MateriList()
        {
            Console.WriteLine("=== MATERI 2: KOLEKSI DINAMIS List<T> ===");

            List<string> siswa = new List<string>();
            siswa.Add("Andi");
            siswa.Add("Budi");
            siswa.Remove("Andi");

            Console.WriteLine("Isi List Siswa:");
            foreach (var s in siswa)
            {
                Console.WriteLine(s);
            }
        }

        // ----------------------------------------------------
        // STUDI KASUS (SESUAI MODUL BAB 12)
        // ----------------------------------------------------

        // Studi Kasus 1: Menyimpan nilai 10 siswa dalam array
        private static void StudiKasusNilai10Siswa()
        {
            Console.WriteLine("=== STUDI KASUS 1: MENYIMPAN NILAI 10 SISWA ===");
            int[] nilaiSiswa = new int[10];

            for (int i = 0; i < nilaiSiswa.Length; i++)
            {
                Console.Write($"Masukkan nilai siswa ke-{i + 1}: ");
                nilaiSiswa[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nDaftar Nilai 10 Siswa:");
            for (int i = 0; i < nilaiSiswa.Length; i++)
            {
                Console.WriteLine($"Siswa ke-{i + 1}: {nilaiSiswa[i]}");
            }
        }

        // Studi Kasus 2: Menghitung nilai tertinggi dan rata-rata
        private static void StudiKasusNilaiTertinggiDanRataRata()
        {
            Console.WriteLine("=== STUDI KASUS 2: NILAI TERTINGGI DAN RATA-RATA ===");
            Console.Write("Masukkan jumlah siswa/data: ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            int[] nilai = new int[jumlah];
            int total = 0;

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"Masukkan nilai siswa ke-{i + 1}: ");
                nilai[i] = Convert.ToInt32(Console.ReadLine());
                total += nilai[i];
            }

            int tertinggi = nilai[0];
            foreach (int n in nilai)
            {
                if (n > tertinggi)
                {
                    tertinggi = n;
                }
            }

            double rataRata = (double)total / nilai.Length;

            Console.WriteLine("\n--- HASIL HASIL PERHITUNGAN ---");
            Console.WriteLine($"Nilai Tertinggi = {tertinggi}");
            Console.WriteLine($"Rata-Rata Nilai = {rataRata:F2}");
        }

        // Studi Kasus 3: Mengelola daftar nama menggunakan List<T>
        private static void StudiKasusKelolaListNama()
        {
            Console.WriteLine("=== STUDI KASUS 3: MENGELOLA DAFTAR NAMA DENGAN List<T> ===");
            List<string> daftarNama = new List<string> { "Andi", "Budi", "Cici" };

            Console.WriteLine("Daftar Awal:");
            foreach (var n in daftarNama) Console.WriteLine("- " + n);

            Console.Write("\nTambah nama baru: ");
            string namaBaru = Console.ReadLine();
            daftarNama.Add(namaBaru);

            Console.Write("Hapus nama: ");
            string namaHapus = Console.ReadLine();
            daftarNama.Remove(namaHapus);

            Console.WriteLine("\nDaftar Nama Terkini:");
            foreach (var n in daftarNama) Console.WriteLine("- " + n);
        }

        // ----------------------------------------------------
        // MINI PROJECT (SESUAI TEKS KODE MODUL BAB 12)
        // ----------------------------------------------------
        private static void MiniProjectRataRataArray()
        {
            Console.WriteLine("=== MINI PROJECT BAB 12 ===");
            int[] nilai = { 75, 80, 90, 85, 70 };
            int total = 0;
            foreach (int n in nilai)
                total += n;

            Console.WriteLine($"Rata-rata = {(double)total / nilai.Length}");
        }

        // ----------------------------------------------------
        // LATIHAN (SESUAI PERINTAH MODUL BAB 12)
        // ----------------------------------------------------

        // Latihan 1: Buat program mencari nilai terbesar dalam array
        private static void LatihanNilaiTerbesar()
        {
            Console.WriteLine("=== LATIHAN 1: MENCARI NILAI TERBESAR DALAM ARRAY ===");
            int[] angka = { 12, 45, 67, 23, 89, 34, 90, 15 };

            int terbesar = angka[0];
            for (int i = 1; i < angka.Length; i++)
            {
                if (angka[i] > terbesar)
                {
                    terbesar = angka[i];
                }
            }

            Console.WriteLine("Isi Array: " + string.Join(", ", angka));
            Console.WriteLine($"Nilai Terbesar = {terbesar}");
        }

        // Latihan 2: Buat program menghitung jumlah bilangan genap dalam array
        private static void LatihanJumlahBilanganGenap()
        {
            Console.WriteLine("=== LATIHAN 2: MENGHITUNG JUMLAH BILANGAN GENAP ===");
            int[] data = { 1, 4, 7, 8, 10, 13, 16, 19, 20 };

            int jumlahGenap = 0;
            int totalGenap = 0;

            foreach (int x in data)
            {
                if (x % 2 == 0)
                {
                    jumlahGenap++;
                    totalGenap += x;
                }
            }

            Console.WriteLine("Isi Data: " + string.Join(", ", data));
            Console.WriteLine($"Banyaknya Bilangan Genap = {jumlahGenap}");
            Console.WriteLine($"Total Sum Bilangan Genap = {totalGenap}");
        }

        // Latihan 3: Aplikasi daftar nama menggunakan List<T>
        private static void LatihanAplikasiDaftarNama()
        {
            List<string> namaSiswa = new List<string>();
            bool jalan = true;

            while (jalan)
            {
                Console.Clear();
                Console.WriteLine("=== LATIHAN 3: APLIKASI DAFTAR NAMA (List<T>) ===");
                Console.WriteLine("1. Lihat Daftar Nama");
                Console.WriteLine("2. Tambah Nama");
                Console.WriteLine("3. Hapus Nama");
                Console.WriteLine("4. Kembali ke Menu Bab 12");
                Console.Write("Pilih Option (1-4): ");

                string opt = Console.ReadLine()?.Trim();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n--- Daftar Nama ---");
                        if (namaSiswa.Count == 0)
                        {
                            Console.WriteLine("(Daftar masih kosong)");
                        }
                        else
                        {
                            for (int i = 0; i < namaSiswa.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {namaSiswa[i]}");
                            }
                        }
                        Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Write("Masukkan nama yang ingin ditambahkan: ");
                        string t = Console.ReadLine();
                        namaSiswa.Add(t);
                        Console.WriteLine("Nama berhasil ditambahkan!");
                        Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Write("Masukkan nama yang ingin dihapus: ");
                        string h = Console.ReadLine();
                        if (namaSiswa.Remove(h))
                            Console.WriteLine("Nama berhasil dihapus!");
                        else
                            Console.WriteLine("Nama tidak ditemukan!");
                        Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                        Console.ReadLine();
                        break;

                    case "4":
                        jalan = false; // Mematikan loop while secara bersih
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}