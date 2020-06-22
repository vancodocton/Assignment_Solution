using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Class
   {
      private List<Student> Students = new List<Student>();

      public string Name;
      public bool AddName(string name)
      {
         Name = name;
         return true;
      }

      public string Curriculum;
      public bool AddCurriculim(string curriculum)
      {
         Curriculum = curriculum;
         return true;
      }
   }
}
