using System;

namespace c8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have? ");
            var _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            if (_numberOfSiblings < 1)
                Console.WriteLine("Okay. That's cool man.");
            else
            {
                string[] siblings = new string[_numberOfSiblings];

                if (_numberOfSiblings == 1)
                {
                    Console.Write("What's your siblings name? ");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for (var i = 0; i < _numberOfSiblings; i++)
                    {
                        if (i == 0)
                            Console.Write("What's your first siblings name? ");
                        else
                            Console.Write("And your next siblings name is? ");

                        siblings[i] = Console.ReadLine();
                    }
                }


                if (_numberOfSiblings == 1)
                    Console.Write("So correct me if I am wrong. Your sibling is ");
                else
                    Console.Write("So correct me if I am wrong. Your siblings are ");

                foreach (var sibling in siblings)
                {
                    Console.Write($"{sibling} ");
                }

            }


           
        }
    }
}
