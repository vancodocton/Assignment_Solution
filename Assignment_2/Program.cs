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
         University university = new University();

         university.AddName("University of Greenwich");
         university.AddStudent();
         
         _ = Console.ReadKey();
      }
   }
}
