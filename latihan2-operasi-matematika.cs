using System;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args){
            int angka1 = 10;
        int angka2 = 5;

        int hasilPenjumlahan = angka1 + angka2;
        Console.WriteLine("penjumlahan : " + hasilPenjumlahan);

        int hasilPengurangan = angka1 - angka2;
        Console.WriteLine("pengurangan : " + hasilPengurangan);

         int hasilPerkalian = angka1 * angka2;
        Console.WriteLine("perkalian : " + hasilPerkalian);

         int hasilPembagian = angka1 / angka2;
        Console.WriteLine("pembagian : " + hasilPembagian);
        }
    }
}