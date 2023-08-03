using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    public class Subject
    {
        public string Sub_Name { set; get; }
        public int Sub_Code { set; get; }
        public string Sub_Teacher { set; get; }
        public Subject(string sub_Name, int sub_Code, string sub_Teacher)
        {
            Sub_Name = sub_Name;
            Sub_Code = sub_Code;
            Sub_Teacher = sub_Teacher;
        }
    }
}
