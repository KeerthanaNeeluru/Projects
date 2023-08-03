using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    public class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public string Section { get; set; }
        public Student(string name,int cl,string section)
        {
            Name = name;
            Class = cl;
            Section = section;
        }
        public override string ToString()
        {
            return $"Student Name : {Name}, Class : {Class}, Section : {Section}";
        }


    }
}
