using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Student
   {
      public int ID { get; private set; }
      public bool AddID(int id)
      {
         if (id > 0)
         {
            ID = id;
            return true;
         }
         else return false;
      }

      public string FullName { get; private set; }
      public bool AddName(string fullName)
      {
         FullName = fullName;
         return true;
      }
   }
}
