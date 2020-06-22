using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   class Program
   {
      static void Main(string[] args)
      {
         Student student = new Student();
         float res;
         do
         {
            do
            {
               Console.Write("Enter student grade  [0 -> 10]: ");
            } while (!float.TryParse(Console.ReadLine(), out res));
         } while (!student.AddMark(res));

         student.ID = 0;

         Console.WriteLine("Mark: "+student.Mark);
         Console.WriteLine("Mark: "+student.Grade());
         Class class1 = new Class();
         Console.ReadKey();
      }
   }
}
