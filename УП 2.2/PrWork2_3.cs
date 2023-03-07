using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork2_3
    {
        public class Nums
        {
            private int a;
            private int b;

            public void printNums(int a, int b)
            {
                Console.WriteLine($"{a}, {b}");
            }
            
            public void Change(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int sum()
            {
                return a + b;
            }

            public int Biggest()
            {
                return a > b ? a : b;
            }
            public Nums(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        static void Main()
        {
            Nums numbers = new Nums(10, 11);
            numbers.printNums(10, 11);
            Console.WriteLine(numbers.sum());
            Console.WriteLine(numbers.Biggest());
            numbers.Change(10, 11);
            numbers.printNums(10, 11);
        }
    }
}