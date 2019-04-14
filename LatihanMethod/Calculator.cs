﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    public class Calculator
    {
        /// <summary>
        /// penjumlahan dua angka
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>

        public int Penjumlahan(int a,int b) 
        {
            return a + b;
        }

        //overload methoad
        public int Penjumlahan(int a, int b, int c) {
            return a + b + c;
        }

        public int Pengurangan(int a, int b) {
            return a - b;
        }

        //method static
        public static int Perkalian(int a, int b) {
            return a * b;
            
        }
    }
}
