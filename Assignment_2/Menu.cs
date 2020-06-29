using System;

namespace GraddingSystem
{
   internal class Menu
   {
      internal protected void DisplayMenu()
      {
         Console.WriteLine("=======================================================");
         Console.WriteLine("       Student Grading Calculation ");
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
         _ = Console.ReadKey();
      }
   }
}
