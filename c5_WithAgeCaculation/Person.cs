using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace c5_WithAgeCaculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateofBirth { get; set; }

        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your Name? ");
            Name = Console.ReadLine();
            Console.Write($"Welcome {Name}! Sweet :) ");
        }

        public void AskForAge()
        {
            Console.Write($"How old ar you man! .");
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"NO {Name}, digital number please");
                Console.WriteLine("NO Try again :)");
                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("STUPID");
                }

            }
            finally
            {
                Console.WriteLine($"Great{Name}, we ar the same age {Age}");
            }

            
        }

        public void AskForDateofBirth()
        {
            Console.WriteLine("when were you born?");
            try
            {
                DateofBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude, I mean when, like 1999-01-01. So when were you born? ");
                try
                {
                    DateofBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid man.");
                }

                Console.WriteLine($"Oh cool man! We are the same age. I am also {CalculateAge()}");
            }
            
        }
        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateofBirth.Year;
            if (DateTime.Now.DayOfYear > DateofBirth.DayOfYear)
                Age = Age - 1;
            return Age;


        }

    }
}