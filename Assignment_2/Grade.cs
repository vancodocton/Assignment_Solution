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
      public float Midterm { get; private set; }
      public float Final { get; private set; }
      public float Total
      {
         get
         {
            return (Monthly.Average() + Midterm * 2 + Final * 3) / 6;
         }
      }
      public char GetGrade()
      {
         float mark = Total;
         if (Final < 5 || Midterm < 5)
         {
            return 'F';
         }
         else if (mark < 4.5)
         {
            return 'F';
         }
         else if (mark < 8)
         {
            return 'P';
         }
         else if (mark < 10)
         {
            return 'M';
         }
         else return 'D';
      }

      public bool AddMonthlyGrade(float grade)
      {
         if (CheckGrade(grade))
         {
            Monthly.Add(grade);
            return true;
         }
         else return false;
      }
      public bool AddMidtermGrade(float grade)
      {
         if (CheckGrade(grade))
         {
            Midterm = grade;
            return true;
         }
         else return false;
      }
      public bool AddFinalGrade(float grade)
      {
         if (CheckGrade(grade))
         {
            Final = grade;
            return true;
         }
         else return false;
      }
      public Grade()
      {
         Monthly = new List<float>();
         Midterm = 0;
         Final = 0;
      }
      private protected bool CheckGrade(float grade)
      {
         if (grade >= 0 && grade <= 10)
         {

            return true;
         }
         else
         {
            return false;
         }
      }
   }
}

