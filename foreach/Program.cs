using System;
using System.Security.Cryptography.X509Certificates;

namespace foreachtest
{
    class Program
{
        
        static void Main(string[] args)
        {

            string name;
            int age = 0;
              

            Console.Write("Welcome Dude! What's your name? ");
            name = Console.ReadLine();
            Console.WriteLine($"hi {name}, How old are you?");

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"NO {name}, digital number please");
                Console.WriteLine("NO Try again :)");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("STUPID");
                }

            }
            finally
            {
                Console.WriteLine($"Great{name}, we ar the same age{age}");
            }
        }
}
}
