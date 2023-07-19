using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19JulyParameterisedConstructorEx
{
    public class Student
    {
        int id;
        string name;
        DateTime dob;
        public Student(int id,string name,DateTime dob)
        {
            Console.WriteLine("Parameterised Constructor of Student");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public void Display()
        {
            Console.WriteLine("Student Details as follows !!");
            Console.WriteLine("ID:->"+id +"\t Name:->"+name +"\t Date of Birth:-> "+dob);
        }
    }
    
    
}
