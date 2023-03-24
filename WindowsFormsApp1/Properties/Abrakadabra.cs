using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class Person 
    {
        public override string ToString()
        {
            return $"{Name} ur.{BrithDate.ToLongDateString()} ({Height}cm)";
        }
        
    }
}
