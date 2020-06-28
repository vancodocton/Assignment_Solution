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
         Console.WriteLine(" Press 1 to calculate total grade");
         Console.WriteLine(" Press 2 to get help");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("=======================================================");
      }
      internal protected void DisplayHelpMessage()
      {
         Console.WriteLine(" 1.The grade is a real number in the range from 0 to 10");
         Console.WriteLine(" 2.The grade of Midterm or Final Exam is under 5, the ");
         Console.WriteLine("   total grade is definitely Fail.");
         Console.WriteLine(" 3. The grade scale:");
         Console.WriteLine("\t* [0;5)  -> Fail        -> F");
         Console.WriteLine("\t* [5;8)  -> Pass        -> P");
         Console.WriteLine("\t* [8;10) -> Merit       -> M");
         Console.WriteLine("\t* 10     -> Distinction -> D");
      }
      internal protected void DisplayExitMessage()
      {
         Console.Write(" Thanks for using. Press any key to exit... ");
         _ = Console.ReadKey();
      }
   }
}
