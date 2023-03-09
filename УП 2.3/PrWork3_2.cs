using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork3_2
    {
        public class Worker
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
            }
            
            private string surname;
            public string Surname
            {
                get
                {
                    return surname;
                }
            }
            
            private int rate;
            public int Rate
            {
                get
                {
                    return rate;
                }
            }
            
            private int days;
            public int Days
            {
                get
                {
                    return days;
                }
            }
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

