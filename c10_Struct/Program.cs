using System;

namespace c10_Struct
{
   
    class ClassExemple
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }

        public ClassExemple(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;

        }
        public void Displayvalues()
        {
            Console.WriteLine($"Displayalues {Nr1} , {Nr2}");
        }

        public void Modify(dynamic d)
        {
            d.Nr1 += 1;
            d.Nr2 += 1;

        }

        internal void Modify()
        {
            Nr1 += 1;
            Nr2 += 1;
        }
    }
    class program
    {
       
        static void Main(string[] args)
        {
            var classexemple = new ClassExemple(1, 1);
            classexemple.Displayvalues();

            classexemple.Modify();
            


        }
    }
}
    