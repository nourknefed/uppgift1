using System;
using System.Collections.Generic;
using System.Text;

namespace c4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

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
    }
}
