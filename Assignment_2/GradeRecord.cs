using System.Collections.Generic;

namespace GraddingSystem
{
   internal class GradeRecord
   {
      protected List<float> MonthMarks { get; private set; }
      internal protected float MidtermMark { get; private set; }
      internal protected float FinalMark { get; private set; }

      internal protected float AverageMonthMarks
      {
         get
         {
            if (MonthMarks.Count == 0)
            {
               return 0;
            }
            else
            {
               float averageMark = 0;
               foreach (float mark in MonthMarks)
               {
                  averageMark += mark;
               }
               return averageMark / MonthMarks.Count;
            }
         }
      }
      internal protected float TotalMark
      {
         get
         {
            return (AverageMonthMarks + (MidtermMark * 2) + (FinalMark * 3)) / 6;
         }
      }
      internal protected char TotalGrade
      {
         get
         {
            foreach (var mark in MonthMarks)
            {
               if (mark < 4)
               {
                  return 'F';
               }
            }
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
      internal protected bool AddMonthlyMark(float mark)
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
      internal protected bool AddMidtermMark(float mark)
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
      private static bool IsMarkValid(float mark)
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

