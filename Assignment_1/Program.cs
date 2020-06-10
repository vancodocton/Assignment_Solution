using System;
using System.Collections.Generic;

namespace Assignment_1
{
   class Program
   {
      static void Main()
      {
         List<int> nums = new List<int>();
         int userChoice;
         do
         {
            DisplayMenu();
            userChoice = GetUserChoice();
            ExecuteOption(nums, userChoice);
         } while (userChoice != 0);

      }

      private static void DisplayMenu()
      {
         Console.WriteLine("===================================================");
         Console.WriteLine("    Finding biggest numbers in the integer array");
         Console.WriteLine("===================================================");
         Console.WriteLine(" Press 1 to add a number");
         Console.WriteLine(" Press 2 to add numbers");
         Console.WriteLine(" Press 3 to display all numbers");
         Console.WriteLine(" Press 4 to display the biggest number(s)");
         Console.WriteLine(" Press 0 to exit the program");
         Console.WriteLine("===================================================");
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
      private static int EnterNumber()
      {
         Console.Write("Enter a number: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            return res;
         }
         return EnterNumber();
      }
      private static int EnterQuantity()
      {
         Console.Write("Enter the number of numbers: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            return res;
         }
         return EnterQuantity();
      }
      private static int EnterNumber(int index)
      {
         Console.Write($"Enter the {index} number: ");

         if (int.TryParse(Console.ReadLine(), out int res))
         {
            return res;
         }
         return EnterNumber(index);
      }
      private static void EnterManyNumbers(List<int> nums)
      {
         int n = EnterQuantity();
         for (int i = 1; i <= n; i++)
         {
            nums.Add(EnterNumber(i));
         }
      }
      private static void DisplayNums(List<int> nums)
      {
         if (nums.Count == 0)
         {
            Console.WriteLine("There's nothing entered");
            return;
         }
         Console.WriteLine("| {0,10} | {1,10} |", "NO", "Value");
         for (int i = 0; i < nums.Count; i++)
         {
            Console.WriteLine("| {0,10} | {1,10} |", i + 1, nums[i]);
         }
         return;
      }
      private static void DisplayMaxNums(List<int> nums, List<int> index)
      {
         Console.WriteLine("| {0,10} | {0,10} |", "NO", "ID");
         for (int i = 0; i < index.Count; i++)
         {
            Console.WriteLine("| {0,10} | {1,10} |", i + 1, nums[index[i]]);
         }
      }
      private static void DisplayBiggestNums(List<int> nums)
      {
         if (nums.Count == 0)
         {
            Console.WriteLine("There's nothing entered");
            return;
         }
         List<int> index = new List<int>();
         int maxNum = int.MinValue;

         for (int i = 0; i < nums.Count; i++)
         {
            if (nums[i] > maxNum)
            {
               maxNum = nums[i];
               index = new List<int> { i };
            }
            else if (nums[i] == maxNum)
            {
               index.Add(i);
            }
         }

         Console.WriteLine("The highest grade: {0}", maxNum);
         DisplayMaxNums(nums, index);
         return;
      }
      private static void DisplayExitMessage()
      {
         Console.Write("Thanks for using. Press any key to exit...");
         _ = Console.ReadKey();
      }
      private static void ExecuteOption(List<int> nums, int userChoice)
      {
         switch (userChoice)
         {
            case 1:
               nums.Add(EnterNumber());
               break;
            case 2:
               EnterManyNumbers(nums);
               break;
            case 3:
               DisplayNums(nums);
               break;
            case 4:
               DisplayBiggestNums(nums);
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
