using System;
using System.Collections.Generic;
using System.Text;

namespace c3_withAclass
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
    class Teacher : Person
    {
        Person p = new Person();

    }

}
