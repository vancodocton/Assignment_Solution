using System.Collections.Generic;

namespace Assignment_2
{
   internal class GradeRecord
   {
      protected List<float> MonthlyMarks { get; private set; }
      protected internal float MidtermMark { get; private set; }
      protected internal float FinalMark { get; private set; }
      protected internal float AverageMonthMarks
      {
         get
         {
            if (MonthlyMarks.Count == 0)
            {
               return 0;
            }
            else
            {
               float averageMark = 0;
               foreach (float mark in MonthlyMarks)
               {
                  averageMark += mark;
               }
               return averageMark / MonthlyMarks.Count;
            }
         }
      }
      protected internal float TotalMark
      {
         get
         {
            return (AverageMonthMarks + (MidtermMark * 2) + (FinalMark * 3)) / 6;
         }
      }
      protected internal char TotalGrade
      {
         get
         {
            foreach (var mark in MonthlyMarks)
            {
               if (mark < 4)
               {
                  return 'F';
               }
            }
            if (FinalMark < 5 || MidtermMark < 5 || TotalMark < 4.5)
            {
               return 'F';
            }
            else
            {
               if (TotalMark < 8)
               {
                  return 'P';
               }
               else
               {
                  if (TotalMark < 10)
                  {
                     return 'M';
                  }
                  else
                  {
                     return 'D';
                  }
               }
            }
         }
      }

      protected internal GradeRecord()
      {
         MonthlyMarks = new List<float>();
         MidtermMark = 0;
         FinalMark = 0;
      }

      private static bool IsMarkValid(float mark)
      {
         return mark >= 0 && mark <= 10;
      }
      protected internal bool AddMonthMark(float mark)
      {
         if (IsMarkValid(mark))
         {
            MonthlyMarks.Add(mark);
            return true;
         }
         else
         {
            return false;
         }
      }
      protected internal bool AddMidtermMark(float mark)
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
      protected internal bool AddFinalMark(float mark)
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
   }
}

