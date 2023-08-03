using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    public class Teachers
    {
       public string TName { get; set; }
        public int TClass { get; set; }
        public string TSection { get; set; }
        public Teachers(string tname,int tclass,string tsection )
        {
            TName = tname;

            TClass = tclass;
            TSection = tsection;
        }

    }
}
