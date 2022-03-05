using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        /// <summary>
        /// Deklarasi variabel angka pertama, angka kedua, dan hasil
        /// </summary>
        public double angka1, angka2, hasil;

        /// <summary>
        /// Method input
        /// Untuk meminta input dari user 
        /// Input disimpan pada variabel angka1 dan angka2
        /// </summary>
        public void input()
        {
            Console.WriteLine(" ========================================");
            Console.WriteLine(" Kalkulator Sederhana");
            Console.WriteLine(" ========================================");
            Console.WriteLine("Masukkan angka 1: ");
            angka1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan angka 2: ");
            angka2 = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Method Tambah
        /// </summary>
        /// <returns>Hasil dari penjumlahan angka1 dengan angka2</returns>
        public double tambah()
        {
            hasil = angka1 + angka2;
            return hasil;
        }

        /// <summary>
        /// Method Kurang
        /// </summary>
        /// <returns>hasil dari pengurangan angka1 dengan angka2</returns>
        public double kurang()
        {
            hasil = angka1 - angka2;
            return hasil;
        }

        /// <summary>
        /// Method Kali
        /// </summary>
        /// <returns>Hasil dari perkalian angka1 dengan angka2</returns>
        public double kali()
        {
            hasil = angka1 * angka2;
            return hasil;
        }

        /// <summary>
        /// Method Bagi
        /// </summary>
        /// <returns>Hasil pembagian angka1 dengan angka2</returns>
        public double bagi()
        {
            hasil = angka1 / angka2;
            return hasil;
        }


        /// <summary>
        /// Method tampil
        /// Method untuk menampilkan hasil dari setiap operasi pada kalkulator
        /// </summary>
        public void tampil()
        {
            Console.WriteLine(" ========================================");
            Console.WriteLine(" |	Hasil");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | Penjumlahan  =  " + tambah());
            Console.WriteLine(" | Pengurangan     =  " + kurang());
            Console.WriteLine(" | Pembagian      =  " + bagi());
            Console.WriteLine(" | Perkalian     =  " + kali());
            Console.WriteLine(" ========================================");
            Console.ReadLine();
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instansiasi
            Program pr = new Program();
            pr.input();
            pr.tampil();
        }
    }
}
