using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student180
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.Name = "Mirza";
            

            Student student2 = new Student("Mirza", "Pecanac", "miki@hotmail.com", "SA");
            Student student3 = new Student("Amira", "Halilovic", "amira@bih.net.ba");
            
            Console.WriteLine(student2.GetStudentInfo());
            Console.WriteLine(student3.GetStudentInfo());
            Console.WriteLine(student1.GetStudentInfo());
           



            


            
        
        
        }
    }
}
