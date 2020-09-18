using System;

namespace Randomtemp
{
    class Program
    {
        public Random temp;
        static void Main(string[] args)
        {
            Random Num = new Random();
            int rNum;
            rNum = Num.Next(18,50);
          
            

            if(rNum > 30)
            {
                Console.WriteLine($"The tempreture now is {rNum} . It´s too hot.");
            }
            else
            {
                Console.WriteLine($"The tempreture now is {rNum} . It´s a nice day");
            }
        }
    }
}
