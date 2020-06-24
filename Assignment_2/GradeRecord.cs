using System.Collections.Generic;
using System.Linq;

namespace GraddingSystem
{
   internal class GradeRecord
   {
      internal List<float> MonthMarks { get; private set; }
      internal float MidtermMark { get; private set; }
      internal float FinalMark { get; private set; }

      internal float TotalMark
      {
         get
         {
            if (MonthMarks.Count == 0)
            {
               return 0;
            }
            else
               return (MonthMarks.Average() + (MidtermMark * 2) + (FinalMark * 3)) / 6;
         }
      }
      internal char TotalGrade
      {
         get
         {
            if (FinalMark < 5 || MidtermMark < 5)
            {
               return 'F';
            }
            else if (TotalMark < 4.5)
            {
               return 'F';
            }
            else if (TotalMark < 8)
            {
               return 'P';
            }
            else if (TotalMark < 10)
            {
               return 'M';
            }
            else
            {
               return 'D';
            }
         }
      }
      internal bool AddMonthlyMark(float mark)
      {
         if (IsMarkValid(mark))
         {
            MonthMarks.Add(mark);
            return true;
         }
         else
         {
            return false;
         }
      }
      internal bool AddMidtermMark(float mark)
      {
         if (IsMarkValid(mark))
         {
            MidtermMark = mark;
            return true;
         }
         else
         {
            return false;
         }
      }
      internal protected bool AddFinalMark(float mark)
      {
         if (IsMarkValid(mark))
         {
            FinalMark = mark;
            return true;
         }
         else
         {
            return false;
         }
      }
      internal GradeRecord()
      {
         MonthMarks = new List<float>();
         MidtermMark = 0;
         FinalMark = 0;
      }
      private protected bool IsMarkValid(float mark)
      {
         if (mark >= 0 && mark <= 10)
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

