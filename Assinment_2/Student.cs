using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Student
   {
      public static float MinMark = 0;
      public static float MaxMark = 10;

      public int ID;
      public bool AddID(int id)
      {
         if (id > 0)
         {
            ID = id;
            return true;
         }
         else return false;
      }

      public string Name;
      public bool AddName(string name)
      {
         Name = name;
         return true;
      }

      public float Mark = 0;
      public bool AddMark(float mark)
      {
         if (mark >= MinMark && mark <= MaxMark)
         {
            Mark = mark;
            return true;
         }
         else return false;
      }

      public char Grade()
      {
         if (Mark < 4.5)
         {
            return 'F';
         }
         else if (Mark < 8)
         {
            return 'P';
         }
         else if (Mark < 10)
         {
            return 'M';

         }
         else return 'D';
      }
   }
}
