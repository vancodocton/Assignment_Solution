using System;

namespace Assignment_2
{
   internal class Application
   {
      private GradeRecord Record { get; set; }
      private readonly Menu Menu = new Menu();

      internal protected void Run()
      {
         int userChoice;

         do
         {
            Menu.DisplayMenu();
            userChoice = GetUserChoice();
            ExecuteOption(userChoice);
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
      private void ExecuteOption(int userChoice)
      {
         switch (userChoice)
         {
            case 1:
               CalculateTotalGrade();
               break;
            case 2:
               Menu.DisplayHelpMessage();
               break;
            case 0:
               Menu.DisplayExitMessage();
               break;
            default:
               break;
         }
      }
      private void CalculateTotalGrade()
      {
         Record = new GradeRecord();
         AddMonthlyMarks();
         AddMidtermMark();
         AddFinalMark();
         Menu.DisplayGradeStatus(Record);
      }
      private void AddMonthlyMarks()
      {
         string[] ordinal = new string[] { "first", "second", "third", "fourth" };
         Console.WriteLine("=======================================================");
         for (int i = 0; i < 4; i++)
         {
            do
            {
               Console.Write(" {0,-" + Utils.MAX_STRING_LINE + "}", $"Enter mark of the {ordinal[i]} Month Exam: ");
            } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddMonthMark(mark));
         }
      }
      private void AddMidtermMark()
      {
         Console.WriteLine("  =======");
         do
         {
            Console.Write(" {0,-" + Utils.MAX_STRING_LINE + "}", "Enter mark of the Midterm Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddMidtermMark(mark));
      }
      private void AddFinalMark()
      {
         Console.WriteLine("  =======");
         do
         {
            Console.Write(" {0,-" + Utils.MAX_STRING_LINE + "}", "Enter mark of the Final Exam: ");
         } while (!float.TryParse(Console.ReadLine(), out float mark) || !Record.AddFinalMark(mark));
      }

   }
}
