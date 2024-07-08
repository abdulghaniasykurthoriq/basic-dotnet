using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Mendefinisikan list of objects untuk menyimpan data warna
        List<Warna> daftarWarna = new List<Warna>
        {
            new Warna { Nama = "Merah", Nilai = "#f00" },
            new Warna { Nama = "Hijau", Nilai = "#0f0" },
            new Warna { Nama = "Biru", Nilai = "#00f" }
        };

        // Iterasi dan mencetak setiap warna
        foreach (var warna in daftarWarna)
        {
            Console.WriteLine($"Warna: {warna.Nama}, Nilai: {warna.Nilai}");
        }
    }

    // Definisikan kelas untuk menyimpan data warna
    class Warna
    {
        public string Nama { get; set; }
        public string Nilai { get; set; }
    }
}
