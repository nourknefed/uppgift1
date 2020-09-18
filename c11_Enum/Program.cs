using System;

namespace c11_Enum
{
    public enum Level
    {
        Low,
        Normal,
        High,

    }
    class Program
    {
        enum status
    {
        pending,
        production,
        transport,
    }
    
        static void Main(string[] args)
        {
            var temrature = 32;
            var templevel = Level.Normal;

                switch (temrature)
            {
                case var t when t < 10:
                    templevel = Level.Low;
                    break;

                case var t when t > 30:
                    templevel = Level.High;
                    break;
                default:
                    templevel = Level.Normal;
                    break;
            }
            Console.WriteLine(templevel);
        }
    }
}
