using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total=0;

            // Looping
            while (true)
            {
                try
                {
                    // Keluarkan pertanyaan
                    Console.WriteLine("Berapa Lama Berolahraga ?");

                    // Minta inout dari user 
                    input = Console.ReadLine();

                    // Keluar bila user input "quit"
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }

                    //jika input dari user
                    if (Int32.Parse(input) < 0)
                    {
                        Console.WriteLine("Coba Lagi Masukin yang benar");
                        continue;
                    }

                    // Menambahkan inputny
                    total = total + Int32.Parse(input);

                    // Keluar inputnya
                    //Console.WriteLine("Sekarang anda berolahraga sebanyak " + input + " menit. ");
                    Console.WriteLine("Selamat anda telah berolahraga selama " + total + " menit. ");
                }
                
                catch (FormatException)
                {
                    Console.WriteLine("Harap Masukkan nomor");
                }
            }
        }       
    }
}
