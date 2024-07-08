using System;

namespace Latihan5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh penggunaan array
            int[] nilaiArray = { 10, 20, 30, 40, 50 };

            // Mengakses dan mencetak nilai array
            for (int i = 0; i < nilaiArray.Length; i++)
            {
                Console.WriteLine("Nilai index ke-" + i + ": " + nilaiArray[i]);
            }
        }
    }
}
