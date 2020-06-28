using System;

namespace GraddingSystem
{
   internal class Application
   {
      private GradeRecord Record { get; set; }
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
         int userChoice;
         do
         {
            Console.Write(" Enter user choice [0 -> 2]: ");
         } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 2);
         return userChoice;
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
      private void CalculateTotalGrade()
      {
         Record = new GradeRecord();
         AddMonthMarks();
         AddMidtermMark();
         AddFinalMark();
         DisplayGradeStatus();
      }
      private void AddMonthMarks()
      {
         string[] ordinal = new string[] { "first", "second", "third", "fourth", "fifth" };

         for (int i = 0; i < 4; i++)
         {
            do
            {
               Console.Write(" {0,-45}", $"Enter mark of the {ordinal[i]} Month Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddMonthMark(mark));
         }
      }
      private void AddMidtermMark()
      {
         do
         {
            Console.Write(" {0,-45}", "Enter mark of the Midterm Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddMidtermMark(mark));
      }
      private void AddFinalMark()
      {
         do
         {
            Console.Write(" {0,-45}", "Enter mark of the Final Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddFinalMark(mark));
      }
      private void DisplayGradeStatus()
      {
         Console.WriteLine("\n=======================================================");
         Console.WriteLine(" {0,-45}{1:F2}", "The Month Exam's Average Mark: ", Record.AverageMonthMarks);
         Console.WriteLine(" {0,-45}{1:F2}", "The Midterm Exam's Mark: ", Record.MidtermMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The Final Exam's Mark: ", Record.FinalMark);
         Console.WriteLine(" {0,-45}{1:F2}", "The Total Mark: ", Record.TotalMark);
         Console.WriteLine(" {0,-45}{1}", "The Total Grade: ", Record.TotalGrade);
      }
   }
}
