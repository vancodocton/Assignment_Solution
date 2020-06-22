using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Class
   {
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

      private string Curriculum;
      public bool AddCurriculim(string curriculum)
      {
         Curriculum = curriculum;
         return true;
      }
      public string GetCurriculum()
      {
         return Curriculum;
      }
   }
}
