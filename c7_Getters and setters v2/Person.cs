using System;
using System.Collections.Generic;
using System.Text;

namespace c7_Getters_and_setters_v2
{
    class Person
    {
        public string Name { get; set; }
        public int Age
        {
            get {
                int _age = DateTime.Now.Year - DateofBirth.Year;
                if (DateTime.Now.DayOfYear > DateofBirth.DayOfYear)
                    _age = _age - 1;
                return _age;
            }
           private set
            {

            }
        }
          

        public string City { get; set; }
        public DateTime DateofBirth { get; private set; }

        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your Name? ");
            Name = Console.ReadLine();
            Console.Write($"Welcome {Name}! Sweet :) ");
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

                Console.WriteLine($"Oh cool man! We are the same age. I am also");
            }

        }
       
    }
}
