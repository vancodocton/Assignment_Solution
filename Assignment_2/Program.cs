using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Program
   {
      static void Main()
      {
         //int userChoice;
         //do
         //{
         //   DisplayMenu();
         //   userChoice = GetUserChoice();
         //} while (userChoice != 0);

         Grade grade = new Grade();

         Console.WriteLine(grade.MidTerm);
         Console.ReadKey();
      }
      private static void DisplayMenu()
      {
         Console.WriteLine("==================================================");
         Console.WriteLine("       Student Grading Calculation ");
         Console.WriteLine("==================================================");
         Console.WriteLine(" Press 1 to calculate total grade");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("==================================================");
      }
      private static int GetUserChoice()
      {
         int res;
         do
         {
            do
            {
               Console.Write("Enter user choice [0 -> 1]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 0 || res > 1);
         return res;
      }
      private static void ExecuteOption(List<int> grades, int userChoice)
      {
         switch (userChoice)
         {
            case 1:
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
         Console.Write("Thanks for using. Press any key to exit...");
         _ = Console.ReadKey();
      }
   }
}
