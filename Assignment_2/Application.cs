using System;
using System.Linq;

namespace GraddingSystem
{
   internal class Application
   {
      public void Run()
      {
         int userChoice;
         do
         {
            DisplayMenu();
            userChoice = GetUserChoice();
            ExecuteOption(userChoice);
         } while (userChoice != 0);
      }
      private static void DisplayMenu()
      {
         Console.WriteLine("=======================================================");
         Console.WriteLine("       Student Grading Calculation ");
         Console.WriteLine("=======================================================");
         Console.WriteLine(" Press 1 to calculate total grade");
         Console.WriteLine(" Press 2 to get help");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("=======================================================");
      }
      private static int GetUserChoice()
      {
         int inp;
         do
         {
            Console.Write(" Enter user choice [0 -> 2]: ");
         } while (!int.TryParse(Console.ReadLine(), out inp) || inp < 0 || inp > 2);
         return inp;
      }
      private static void ExecuteOption(int userChoice)
      {
         switch (userChoice)
         {
            case 1:
               CalculateTotalGrade();
               break;
            case 2:
               DisplayHelpMessage();
               break;
            case 0:
               DisplayExitMessage();
               break;
            default:
               break;
         }
      }
      private static void DisplayExitMessage()
      {
         Console.Write(" Thanks for using. Press any key to exit...");
         _ = Console.ReadKey();
      }
      private static void CalculateTotalGrade()
      {
         GradeRecord grade = new GradeRecord();

         string[] ordinal = new string[] { "first", "second", "third", "fourth" };
         float res;

         for (int i = 0; i < 4; i++)
         {
            do
            {
               Console.Write(" {0,-45}", $"Enter grade of the {ordinal[i]} Monthly Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out res) || !grade.AddMonthlyMark(res));
         }


         do
         {
            Console.Write(" {0,-45}", "Enter grade of the Midterm Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out res) || !grade.AddMidtermMark(res));

         do
         {
            Console.Write(" {0,-45}", "Enter grade of the Final Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out res) || !grade.AddFinalMark(res));

         Console.WriteLine("\n=======================================================");
         Console.WriteLine(" {0,-45}{1:F2}", "The monthly Exam's average mark: ", grade.MonthMarks.Average());
         Console.WriteLine(" {0,-45}{1:F2}", "The Midterm Exam's mark: ", grade.MidtermMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The Final Exam's mark: ", grade.FinalMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The total mark: ", grade.TotalMark);
         Console.WriteLine(" {0,-45}{1}", "The total grade: ", grade.TotalGrade);
      }
      private static void DisplayHelpMessage()
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
   }
}
