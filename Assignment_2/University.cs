using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class University
   {
      private List<Student> Students = new List<Student>();

      private string Name;
      public bool AddName(string name)
      {
         Name = name;
         return true;
      }
      public string GetName()
      {
         return Name;
      }
      private static int GetID()
      {
         int res;
         do
         {
            Console.Write("Enter student ID [0 -> +oo]: ");
         } while (!int.TryParse(Console.ReadLine(), out res));
         return res;
      }
      public void AddStudent()
      {
         Student student = new Student();
         while (student.AddID(GetID())) ;
      }
   }
}
