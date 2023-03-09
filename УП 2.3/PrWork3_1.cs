using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork3_1
    {
        public class Worker
        {
            public string name;
            public string surname;
            public int rate;
            public int days;

            public int getSalary()
            {
                return rate * days;
            }

            public Worker(string name, string surname, int rate, int days)
            {
                this.name = name;
                this.surname = surname;
                this.rate = rate;
                this.days = days;
            }
        }
        
        static void Main()
        {
            Worker worker = new Worker("Евгений", "Белодед", 1500, 180);
            Console.WriteLine(worker.getSalary());
        }
    }
}

