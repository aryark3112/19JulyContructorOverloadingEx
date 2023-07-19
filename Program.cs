using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19JulyParameterisedConstructorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(12, "Sam", new DateTime(day: 12, month: 09, year: 2010));
            Student stud2 = new Student(11, "Deep", new DateTime(day: 09, month: 11, year: 2009));
            Console.WriteLine("**** Student One ****");
            stud1.Display();
            Console.WriteLine("**** Student Two ****");
            stud2.Display();
            Console.ReadKey();
        }
    }
}
