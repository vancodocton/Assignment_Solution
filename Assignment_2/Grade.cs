using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   internal class Grade
   {
      public List<float> Monthly { get; private set; }
      public float MidTerm { get; private set; }
      public float Final { get; private set; }
      public float Total
      {
         get
         {
            return Total;
         }
         private set
         {
            Total = (Monthly.Average() + MidTerm * 2 + Final * 3) / 6;
         }
      }

      public bool AddMonthlyGrade(float grade)
      {
         if (Monthly.Count > 4)
         {
            return false;
         }
         else if (grade >= 0 && grade <= 10)
         {
            Monthly.Add(grade);
            return true;
         }
         else return false;
      }
      public Grade()
      {
         Monthly = new List<float>();
         MidTerm = 0;
         Final = 0;
      }


   }
}

