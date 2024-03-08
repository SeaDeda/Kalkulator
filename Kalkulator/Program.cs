using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Pilih Menu : ");
            Double pilih = Convert.ToDouble(Console.ReadLine());

            if (pilih == 1)
            {
                Console.Write("Inputkan Nilai a : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilih == 2)
            {
                Console.Write("Inputkan Nilai a : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));

            }
            else if (pilih == 3)
            {
                Console.Write("Inputkan Nilai a : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + Perkalian(a, b));
            }

            else if (pilih == 4)
            {
                Console.Write("Inputkan Nilai a : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian " + a + " : " + b + " = " + Pembagian(a, b));
            }
            else if (pilih >= 5)
                Console.WriteLine("Maaf, Menu yang Anda pilih tidak tersedia");

            Console.WriteLine("Tekan sembarang key untuk keluar");



            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
