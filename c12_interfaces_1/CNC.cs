using c12_interfaces_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace c12_Interface
{
    class CNC : Imachine
    {
        public bool Start()
        {
            Console.WriteLine("machine started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("machine stopped");
            return true;
        }
    }
}
