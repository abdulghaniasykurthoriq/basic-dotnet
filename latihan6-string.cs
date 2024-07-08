using System;

namespace Latihan6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh manipulasi string
            string namaDepan = "John";
            string namaBelakang = "Doe";

            // Menggabungkan string
            string namaLengkap = namaDepan + " " + namaBelakang;
            Console.WriteLine("Nama lengkap: " + namaLengkap);

            // Menggunakan method string
            string teks = "Halo dunia!";
            Console.WriteLine("Panjang teks: " + teks.Length);
            Console.WriteLine("Teks uppercase: " + teks.ToUpper());
            Console.WriteLine("Teks lowercase: " + teks.ToLower());
        }
    }
}
