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
         Console.WriteLine(" Finding student(s) having the highest grade");
         Console.WriteLine("=====================================================");
         Console.WriteLine(" Press 1 to add a student's grade");
         Console.WriteLine(" Press 2 to add a specific number of students' grade");
         Console.WriteLine(" Press 3 to display students' grade entered");
         Console.WriteLine(" Press 4 to display student(s) having highest grade");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("=====================================================");
      }
      private static int GetUserChoice()
      {
         int res;
         do
         {
            do
            {
               Console.Write("Enter user choice [0 -> 4]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 0 || res > 5);
         return res;
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
      private static int EnterStudent()
      {
         int res;
         do
         {
            do
            {
               Console.Write("Enter student's grade [0 -> 100]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 0 || res > 100);
         return res;
      }
      private static int EnterQuantity()
      {
         int res;
         do
         {
            do
            {
               Console.Write("Enter a specific number of students [1 -> 10]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 1 || res > 10);
         return res;
      }
      private static int EnterStudent(int index)
      {
         int res;
         do
         {
            do
            {
               Console.Write($"Enter the {index} student's grade [0 -> 100]: ");
            } while (!int.TryParse(Console.ReadLine(), out res));
         } while (res < 0 || res > 100);
         return res;
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
      }
      private static void DisplayMaxGradeIndex(List<int> indexes)
      {
         Console.WriteLine("| {0,10} | {1,10} |", "NO", "StudentNO");
         for (int i = 0; i < indexes.Count; i++)
         {
            Console.WriteLine("| {0,10} | {1,10} |", i + 1, indexes[i] + 1);
         }
      }
      private static void DisplayMaxGrade(List<int> grades)
      {
         if (grades.Count == 0)
         {
            Console.WriteLine("There's nothing entered");
            return;
         }
         List<int> indexes = new List<int>();
         int maxNum = int.MinValue;

         for (int i = 0; i < grades.Count; i++)
         {
            if (grades[i] > maxNum)
            {
               maxNum = grades[i];
               indexes = new List<int> { i };
            }
            else if (grades[i] == maxNum)
            {
               indexes.Add(i);
            }
         }

         Console.WriteLine("The highest grade: {0}", maxNum);
         DisplayMaxGradeIndex(indexes);
      }
      private static void DisplayExitMessage()
      {
         Console.Write("Thanks for using. Press any key to exit...");
         _ = Console.ReadKey();
      }
   }
}




