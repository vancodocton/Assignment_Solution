using System;

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
      private void ExecuteOption(Menu menu, int userChoice)
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
      protected void CalculateTotalGrade()
      {
         GradeRecord gradeRecord = new GradeRecord();
         string[] ordinal = new string[] { "first", "second", "third", "fourth", "fifth" };
         float mark;

         for (int i = 0; i < 4; i++)
         {
            do
            {
               Console.Write(" {0,-45}", $"Enter mark of the {ordinal[i]} Month Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out mark) || !gradeRecord.AddMonthlyMark(mark));
         }

         do
         {
            Console.Write(" {0,-45}", "Enter mark of the Midterm Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out mark) || !gradeRecord.AddMidtermMark(mark));

         do
         {
            Console.Write(" {0,-45}", "Enter mark of the Final Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out mark) || !gradeRecord.AddFinalMark(mark));

         Console.WriteLine("\n=======================================================");
         Console.WriteLine(" {0,-45}{1:F2}", "The Month Exam's Average Mark: ", gradeRecord.AverageMonthMarks);
         Console.WriteLine(" {0,-45}{1:F2}", "The Midterm Exam's Mark: ", gradeRecord.MidtermMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The Final Exam's Mark: ", gradeRecord.FinalMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The Total Mark: ", gradeRecord.TotalMark);
         Console.WriteLine(" {0,-45}{1}", "The Total Grade: ", gradeRecord.TotalGrade);

         //gradeRecord = null;
         //GC.Collect();
      }
   }
}
