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
        public Person()
        {
            
        }
        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public string getPersonInfo()
        {
            return name + " , " + lastName;
        }
    
    }
    
    class Student : Person 
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
                    base.name = "";
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

        ~Student()
        {
            ;
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
    }
}
