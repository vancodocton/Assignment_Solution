using Assignment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class ListStudent
   {
      private List<Student> students = new List<Student>();

      private static int GetID()
      {
         int res;
         do
         {
            Console.Write("Enter student ID [0 -> +oo]: ");
         } while (!int.TryParse(Console.ReadLine(), out res));
         return res;
      }
      private static char GetGender()
      {
         char res;
         do
         {
            Console.Write("Enter student gender [F, M, U]: ");
         } while (!char.TryParse(Console.ReadLine(), out res));
         return res;
      }
      private int CheckID(List<Student> students, Student student)
      {
         for (int i = 0; i < students.Count; i++)
         {
            if (students[i].ID == student.ID)
            {
               return i;
            }
         }
         return -1;
      }
      public void AddStudent()
      {
         Student student = new Student();

         do
         {
            while (!student.AddID(GetID())) ;
         }
         while (CheckID(students, student) != -1);



         Console.Write("Enter student name: ");
         student.AddName(Console.ReadLine());

         while (!student.AddGender(GetGender())) ;
      }

   }
}
