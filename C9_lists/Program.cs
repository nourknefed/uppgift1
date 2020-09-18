using System;
using System.Collections.Generic;

namespace C9_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool havesiblings;

            Console.WriteLine("Do you have any siblings (yes/no)");

            var _siblingresponse = Console.ReadLine();

            switch (_siblingresponse.ToLower())
            {
                case "yes":
                    havesiblings = true;
                        break;

                        case "no":
                    havesiblings = false;
                        break;
                default:
                    havesiblings = false;
                    break;
            }
         

            if (!havesiblings)
            {
                Console.WriteLine("ok man");
            }

            else
            {
                Console.WriteLine("sweet, hoe many siblings do you have?");
                int _numberofsiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if (_numberofsiblings == 1)
                {
                    Console.WriteLine("What is your sibling´s name?");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"so your sibling´s name is......{siblings[0]}");
                }
                else
                {
                    Console.WriteLine("What is your sibling´s names?, Seperate by comma(,)");
                    var _response = Console.ReadLine();
                    var names = _response.Replace(" ", "").Split(",");

                    foreach (var name in names)
                    {
                        siblings.Add(name);
                    }

                    Console.Write("Which of your siblings are the oldest one? ");
                    var _oldest = Console.ReadLine();
                    var index = siblings.FindIndex(x => x.Contains(_oldest));
                    siblings.RemoveAt(index);
                    siblings.Insert(0, _oldest);

                    Console.Write($"Okay, so your siblings names are ");
                    foreach (var sibling in siblings)
                    {
                        Console.Write($"{sibling} ");
                    }

                }
            }







        }
        

    }
}
