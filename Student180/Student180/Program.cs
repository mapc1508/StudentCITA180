using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Student180
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Student student4 = new Student();
                Console.WriteLine(student4.GetType());
                student4.Name = "X";
                //student4.Name = "xxx";
                //student4.Name = "123";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace + "\n");
                
                Environment.Exit(0);
            }

            Student student1 = new Student();
            Student student2 = new Student("Mirza", "Pecanac", "miki@hotmail.com", "SA");
            Student student3 = new Student("Mirza", "Halilovic", "amira@bih.net.ba");
            Console.WriteLine(student2.GetStudentInfo());
            Console.WriteLine(student3.GetStudentInfo());
            Console.WriteLine(student1.GetStudentInfo());
            Console.WriteLine(student2.ToString());

            Student[] sArray = new Student[10];
            for (int x = 0; x < sArray.Length; ++x)
                sArray[x] = new Student("XXX", "", "", "");

            sArray[0].Name = "Sead";
            sArray[1].Name = "Muamer";
            sArray[2].Name = "Lejla";
            sArray[3].Name = "Amila";
            sArray[4].Name = "Rijad";
            sArray[5].Name = "Eldin";
            sArray[6].Name = "Tarik";
            sArray[7].Name = "Nejla";
            sArray[8].Name = "Hana";
            sArray[9].Name = "Damir";

            //int y = sArray[0].Name.CompareTo(sArray[1].Name);
            //Console.WriteLine(y);

            Console.WriteLine("\nOriginal list:\n");
            int i = 1;
            foreach (Student s in sArray)
            {
                Console.WriteLine(i + ". " + s.Name);
                ++i;
            }
            int y = 1;
            Console.WriteLine("\nSorted list:\n");
            Array.Sort(sArray);
            foreach (Student s in sArray)
            {
                Console.WriteLine(y + ". " + s.Name);
                ++y;
            }

            Console.WriteLine("\nstudent3 object's ID is " + student3.IdObject);

           //Queue collection...
            Queue<Student> queueStudents = new Queue<Student>();
            for (i = 0; i < sArray.Length; ++i )
                queueStudents.Enqueue(sArray[i]);
            queueStudents.Enqueue(student1);
            queueStudents.Enqueue(student2);
            queueStudents.Enqueue(student3);

            Console.WriteLine("\nNumber of items in the queue is " + queueStudents.Count);
            Student newStudent1 = queueStudents.Dequeue();
            Console.WriteLine("\nFirst item removed from queue: " + newStudent1
            + "\nNumber of items in the queue is decreased by one and is now " + queueStudents.Count);
            
            queueStudents.OrderBy(name => name.Name); /*Doesn't sort the queue, 
                                                       * sorting is used primarily in lists*/

            foreach(Student s in queueStudents)
            {
                Console.WriteLine(s.Name);
            }

            if (queueStudents.Contains(student2))
            {
                Console.WriteLine("\nStudent2 object exist within the queue");
            }


            // The following part is a scheduler of classes
            Console.WriteLine("\n----------------------------------------------");

            bool twoOrLess = true;

            try
            {
                Console.Write("Enter number of classes per week: ");
                int j = Convert.ToInt32(Console.ReadLine());

                if (j > 2)
                {
                    twoOrLess = false;
                    Console.WriteLine("You cannot have more than two classes per week");
                    while (!twoOrLess)
                    {
                        Console.WriteLine("You cannot have more than two classes per week");
                        Console.Write("Enter number of classes per week: ");
                        j = Convert.ToInt32(Console.ReadLine());
                    }

                }
                for (int k = 1; k <= j; ++k)
                {


                    if (twoOrLess && j > 0)
                    {
                        Console.WriteLine("(Format dd,mm,yyyy) \nEnter the starting date of your class: ");
                        DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter time when the class starts (e.g. 9:00)");
                        string startTime = Console.ReadLine();
                        Console.WriteLine();

                        Schedule.Scheduler(startDate, startTime);
                    }                   
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
 }

