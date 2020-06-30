using System;

namespace Assignment_2
{
   internal class Menu
   {
     
      internal protected void DisplayMenu()
      {
         Console.WriteLine("=======================================================");
         Console.WriteLine(" Press 1 to calculate the total grade");
         Console.WriteLine(" Press 2 to get help");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("=======================================================");
      }
      internal protected void DisplayHelpMessage()
      {
         Console.WriteLine("=======================================================");
         Console.WriteLine(" 1. The mark is a real number in the range from 0 to 10");
         Console.WriteLine(" 2. The average mark of Monthly Exam and the mark of");
         Console.WriteLine("    Midterm or Final Exam is under 5, the total grade");
         Console.WriteLine("    is definitely Fail.");
         Console.WriteLine(" 3. The grade scale:");
         Console.WriteLine("\t+ Total mark in [0;5)  -> Failed      -> F");
         Console.WriteLine("\t+ Total mark in [5;8)  -> Pass        -> P");
         Console.WriteLine("\t+ Total mark in [8;10) -> Merit       -> M");
         Console.WriteLine("\t+ Total mark is 10     -> Distinction -> D");
      }
      internal protected void DisplayExitMessage()
      {
         Console.WriteLine("=======================================================");
         Console.Write(" Thanks for using. Press any key to exit... ");
      }

      public void DisplayGradeStatus(GradeRecord record)
      {
         Console.WriteLine("=======================================================");
         Console.WriteLine(" {0,-" + Utils.MAX_STRING_LINE + "}" + "{1:F2}", "The Month Exam's Average Mark: ", record.AverageMonthMarks);
         Console.WriteLine(" {0,-" + Utils.MAX_STRING_LINE + "}" + "{1:F2}", "The Midterm Exam's Mark: ", record.MidtermMark);
         Console.WriteLine(" {0,-" + Utils.MAX_STRING_LINE + "}" + "{1:F2}", "The Final Exam's Mark: ", record.FinalMark);
         Console.WriteLine(" {0,-" + Utils.MAX_STRING_LINE + "}" + "{1:F2}", "The Total Mark: ", record.TotalMark);
         Console.WriteLine(" {0,-" + Utils.MAX_STRING_LINE + "}" + "{1}", "The Total Grade: ", record.TotalGrade);
      }
   }
}
