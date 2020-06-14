using System;
using System.Collections.Generic;

namespace Assignment_1
{
   class Program
   {
      static void Main()
      {
         List<int> grades = new List<int>();
         int userChoice;
         do
         {
            DisplayMenu();
            userChoice = GetUserChoice();
            ExecuteOption(grades, userChoice);
         } while (userChoice != 0);

      }

      private static void DisplayMenu()
      {
         Console.WriteLine("=====================================================");
         Console.WriteLine("    Finding student(s) having the highest grade");
         Console.WriteLine("=====================================================");
         Console.WriteLine(" Press 1 to add a student's grade");
         Console.WriteLine(" Press 2 to add a number of students' grade");
         Console.WriteLine(" Press 3 to display all student's grade entered");
         Console.WriteLine(" Press 4 to display student(s) having highest grade");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("=====================================================");
         return;
      }
      private static int GetUserChoice()
      {
         Console.Write("Enter choice [0 -> 4]: ");
         if (int.TryParse(Console.ReadLine(), out int res))
         {
            if (res >= 0 && res <= 4)
               return res;
         }
         return GetUserChoice();
      }
      private static int EnterStudent()
      {
         Console.Write("Enter student's grade [0 -> 100]: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            if (0 <= res && res <= 100)
               return res;
         }
         return EnterStudent();
      }
      private static int EnterQuantity()
      {
         Console.Write("Enter the number of students [1 -> 10]: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            if (0 < res && res <= 10)
               return res;
         }
         return EnterQuantity();
      }
      private static int EnterStudent(int index)
      {
         Console.Write($"Enter the {index} student's grade [0 -> 100]: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            if (0 <= res && res <= 100)
               return res;
         }
         return EnterStudent(index);
      }
      private static void EnterManyStudents(List<int> grades)
      {
         int n = EnterQuantity();
         for (int i = 1; i <= n; i++)
         {
            grades.Add(EnterStudent(i));
         }
      }
      private static void DisplayStudents(List<int> grades)
      {
         if (grades.Count == 0)
         {
            Console.WriteLine("There's nothing entered");
            return;
         }
         Console.WriteLine("| {0,10} | {1,10} |", "NO", "Value");
         for (int i = 0; i < grades.Count; i++)
         {
            Console.WriteLine("| {0,10} | {1,10} |", i + 1, grades[i]);
         }
         return;
      }
      private static void DisplayMaxGradeIndex(List<int> grades, List<int> index)
      {
         Console.WriteLine("| {0,10} | {0,10} |", "NO", "ID");
         for (int i = 0; i < index.Count; i++)
         {
            Console.WriteLine("| {0,10} | {1,10} |", i + 1, grades[index[i]]);
         }
      }
      private static void DisplayMaxGrade(List<int> grades)
      {
         if (grades.Count == 0)
         {
            Console.WriteLine("There's nothing entered");
            return;
         }
         List<int> index = new List<int>();
         int maxNum = int.MinValue;

         for (int i = 0; i < grades.Count; i++)
         {
            if (grades[i] > maxNum)
            {
               maxNum = grades[i];
               index = new List<int> { i };
            }
            else if (grades[i] == maxNum)
            {
               index.Add(i);
            }
         }

         Console.WriteLine("The highest grade: {0}", maxNum);
         DisplayMaxGradeIndex(grades, index);
         return;
      }
      private static void DisplayExitMessage()
      {
         Console.Write("Thanks for using. Press any key to exit...");
         _ = Console.ReadKey();
      }
      private static void ExecuteOption(List<int> grades, int userChoice)
      {
         switch (userChoice)
         {
            case 1:
               grades.Add(EnterStudent());
               break;
            case 2:
               EnterManyStudents(grades);
               break;
            case 3:
               DisplayStudents(grades);
               break;
            case 4:
               DisplayMaxGrade(grades);
               break;
            case 0:
               DisplayExitMessage();
               break;
            default:
               break;
         }
      }
   }
}
