using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuList
{
    class Student : Person
    {
        public int ID { get; set; }

        public Student(int id, string name) : base(name)
        {
            ID = id;
        }
    }
}
