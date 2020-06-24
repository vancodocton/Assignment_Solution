using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   public class Application
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
         int res;
         do
         {
            do
            {
               Console.Write(" Enter user choice [0 -> 2]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 0 || res > 2);
         return res;
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
         Grade grade = new Grade();

         string[] indexes = new string[] { "first", "second", "third", "fourth" };
         float res;

         for (int i = 0; i < 4; i++)
         {
            do
            {
               do
               {
                  Console.Write(" {0,-45}", $"Enter grade of the {indexes[i]} Monthly Exam: ");
               } while (!float.TryParse(Console.ReadLine(), out res));
            } while (!grade.AddMonthlyGrade(res));
         }

         do
         {
            do
            {
               Console.Write(" {0,-45}", "Enter grade of the Midterm Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out res));
         } while (!grade.AddMidtermGrade(res));

         do
         {
            do
            {
               Console.Write(" {0,-45}", "Enter grade of the Final Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out res));
         } while (!grade.AddFinalGrade(res));
         Console.WriteLine("\n=======================================================");
         Console.WriteLine(" {0,-45}{1:F2}", "The monthly Exam's average grade: ", grade.Monthly.Average());
         Console.WriteLine(" {0,-45}{1:F2}", "The Midterm Exam's grade: ", grade.Midterm);
         Console.WriteLine(" {0,-45}{1:F2}", "The Final Exam's grade: ", grade.Final);
         Console.WriteLine(" {0,-45}{1:F2}", "The total grade (number): ", grade.Total);
         Console.WriteLine(" {0,-45}{1}", "The total grade (char): ", grade.GetGrade());
      }
      private static void DisplayHelpMessage()
      {
         Console.WriteLine(" 1.The grade is a real number in the range from 0 to 10");
         Console.WriteLine(" 2.The grade of Midterm or Final Exam is under 5, the ");
         Console.WriteLine("   total grade is definitely Fail.");
         Console.WriteLine(" 3. The grade ladder:");
         Console.WriteLine("\t* [0;5)  -> Fail        -> F");
         Console.WriteLine("\t* [5;8)  -> Pass        -> P");
         Console.WriteLine("\t* [8;10) -> Merit       -> M");
         Console.WriteLine("\t* 10     -> Distinction -> D");
      }
   }
}
