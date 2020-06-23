using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class University
   {
      private List<Student> Students = new List<Student>();

      private string Name;
      public bool AddName(string name)
      {
         Name = name;
         return true;
      }
      public string GetName()
      {
         return Name;
      }

   }
}
