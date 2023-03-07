using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork2_1
    {
        public class Student
        {
            private string Surname;
            private DateTime dateOfBirthday;
            private int group;
            private List<int> grades = new List<int>();

            public void changeInfo(string Surname, DateTime dateOfBirthday, int group)
            {
                this.Surname = Surname;
                this.dateOfBirthday = dateOfBirthday;
                this.group = group;
            }

            public void printInfo()
            {
                Console.WriteLine($"{Surname}, {dateOfBirthday}, {group}");
                foreach (int grade in grades)
                {
                    Console.Write(grade + " ");
                }
            }

            public Student(string Surname, DateTime dateOfBirthday, int group, List<int> grades)
            {
                this.Surname = Surname;
                this.dateOfBirthday = dateOfBirthday;
                this.group = group;
                this.grades = grades;
            }
            
        }
        static void Main()
        {
            Student eugeny = new Student("Белодед", new DateTime(2004, 06, 24), 621, new List<int>() { 5, 5, 5, 5, 5 });
            eugeny.changeInfo(Surname: "Белодед", dateOfBirthday: new DateTime(2004, 06, 24), group: 621 );
            eugeny.printInfo();
        }
    }
}