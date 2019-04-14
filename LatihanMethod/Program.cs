using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variable
            int hasil;

            //membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            //pangil method penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil penjumlahan: " + hasil);

            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil penjumlahan oveload: " + hasil);

            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = Calculator.Perkalian(2, 4);
            CetakHasil("Hasil perkalian: " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil) 
        {
            Console.WriteLine(hasil);
        }
    }
}
