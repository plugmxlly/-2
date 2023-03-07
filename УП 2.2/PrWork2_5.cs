using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork2_5
    {
        public class properties
        {
            private int group;
            private string name;
            public properties()
            {
                group = 621;
                name = "Евгений";
            }
            public properties(int a, string name)
            {
                this.group = group;
                this.name = name;
            }
        
            public void Dispose()
            {
                this.Dispose();
            }
        
            ~properties()
            {
                Console.WriteLine("Обьект удален");
            }
        }

        static void Main()
        {
            properties test1 = new properties();
            properties test2 = new properties(18, "Евгений");
            test2.Dispose();
        }
    }
}