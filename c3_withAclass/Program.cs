using System;

namespace c3_withAclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

          


            Console.Write("Welcome Dude! What's your Name? ");
            person.Name = Console.ReadLine();
            Console.WriteLine($"hi {person.Name}, How old are you?");

            try
            {
               person.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"NO {person.Name}, digital number please");
                Console.WriteLine("NO Try again :)");
                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("STUPID");
                }

            }
            finally
            {
                Console.WriteLine($"Great{person.Name}, we ar the same age{person.Age}");
            }
        }

    }
}
