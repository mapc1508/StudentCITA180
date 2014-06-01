using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student180
{
    class Person
    {
        protected string name, lastName;
        public static string copyright = "Mirza";
        static int count = 0;
        private int idObject;
        public int IdObject
        {
            get 
            { 
                return idObject; 
            }
        }
        public Person()
        {
            ++count;
            idObject = count;
        }
        public Person(string name, string lastName)
        {
            ++count;
            idObject = count;            
            this.name = name;
            this.lastName = lastName;
        }
        public string getPersonInfo()
        {
            return name + " , " + lastName;
        }
    
    }
    
    class Student : Person, IComparable
    {


        public string Name
        {
            get
            {
                return base.name;
            }
            set
            {
                if (SetName(value))
                {
                    base.name = value;
                }
                else
                    base.name = null;
            }
        }
        public string Email { get; set; }
        private string location;
        public string Location
        {
            get
            {
                if (location == "SA") location = "Sarajevo";
                else if (location == "TZ") location = "Tuzla";
                else location = "Other";

                return location;
            }

            set
            {

                if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                    location = "SA";
                else if (value == "TZ" || value == "Tuzla")
                    location = "TZ";
                else
                    location = "NA";
            }

        }
       
        
        public Student()
        {
        }
        public Student(string name, string lastName, string email) : base(name, lastName) 
        {

            Name = name;
            Email = email;
        }
        public Student(string name, string lastName, string email, string location): base(name, lastName)       
        {
            Name = name;
            this.location = location;
            Email = email;
        }
        /* In the email it says that the last constructor should contain name, lastName and location
         * but it makes second and third constructor ambiguous. That is the reason why I included email
         * in the last constructor */
        
        ~Student()
        {           
        }

        public bool SetName(string input)
        {
            char[] charArray = input.ToCharArray();
                      
            if (input.Length < 2)
            {
                Console.WriteLine("Name must be at least two characters long");

                return false; 
            }
                     
            foreach( char c in charArray)
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("Name can only have letters");

                    return false;
                }               
            }

            if (!char.IsUpper(charArray[0]))
            {
                Console.WriteLine("Name must start with an uppercase letter");
                return false;
            }
            return true;              
        }

        public string GetStudentInfo()
        {
            return getPersonInfo() + " , " + Email + " , " + Location;
        }      
    
        int IComparable.CompareTo(Object o)
        {
            Student temp = (Student)o;
            return String.Compare(this.Name, temp.Name);
        }
        // Since my email ends with 6 (mapc1806@aubih.edu.ba) I had to compare names

        public override string ToString()
        {
            return GetStudentInfo();
        }
        
        
    
    }

}
