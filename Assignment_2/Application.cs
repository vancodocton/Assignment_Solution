using System;
using System.Linq;

namespace GraddingSystem
{
   internal class Application
   {
      internal protected void Run()
      {
         int userChoice;
         Menu menu = new Menu();
         do
         {
            menu.DisplayMenu();
            userChoice = GetUserChoice();
            ExecuteOption(menu, userChoice);
         } while (userChoice != 0);
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
      private static void ExecuteOption(Menu menu, int userChoice)
      {
         switch (userChoice)
         {
            case 1:
               CalculateTotalGrade();
               break;
            case 2:
               menu.DisplayHelpMessage();
               break;
            case 0:
               menu.DisplayExitMessage();
               break;
            default:
               break;
         }
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
   }
}
