using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork2_4
    {
        public class Counter
        {
            private int counter;

            public void View()
            {
                Console.WriteLine(counter);
            }

            public void Increment()
            {
                counter++;
            }
            
            public void Decrement()
            {
                counter--;
            }
            
            public Counter()
            {
                counter = 0;
            }

            public Counter(int num)
            {
                counter = num;
            }
        }
        
        static void Main()
        {
            Counter a = new Counter(300);
            a.View();
            for (int i = 0; i < 30; ++i)
            {
                a.Increment();
            }
            a.View();
            
            Counter b = new Counter(205);
            b.View();
            for (int i = 0; i < 30; ++i)
            {
                b.Decrement();
            }
            b.View();
        }
    }
}