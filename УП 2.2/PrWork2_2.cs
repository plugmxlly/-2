using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork2_2
    {
        public class Train
        {
            private string station;
            public int id { get; private set; }
            private DateTime timeDepature;

            public void printInfo()
            {
                Console.WriteLine($"{this.station}, {this.id}, {this.timeDepature}");
            }

            public Train(string station, int id, DateTime timeDepature)
            {
                this.station = station;
                this.id = id;
                this.timeDepature = timeDepature;
            }
        }

        static void Main()
        {
            List<Train> trains = new List<Train>()
            {
                new Train("Томск-1", 101,
                    new DateTime(year: 2012, month: 11, day: 11, hour: 11, minute: 11, second: 0)),
                new Train("Томск-2", 102,
                    new DateTime(year: 2013, month: 11, day: 11, hour: 11, minute: 11, second: 0)),
                new Train("Новосибирск-1", 103,
                    new DateTime(year: 2014, month: 11, day: 11, hour: 11, minute: 11, second: 0))
            };

            int id1 = int.Parse(Console.ReadLine());

            foreach (Train train in trains)
            {
                if (train.id == id1)
                {
                    train.printInfo();
                }
            }
        }
    }
}