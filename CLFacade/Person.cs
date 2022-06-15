using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFacade
{
    public class Person
    {
        //standard properties for the person 
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        private int age;
        public int Age
        {
            //calculating the age through the birthdate
            get
            {
                //the age is equel to the year now - their birthdate year
                age = DateTime.Now.Year - Birthday.Year;

                //this for checking if they havent had a birthday yet in the year
                if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                {
                    age = age - 1;
                };
                return age;
            }

        }


        public string Adress { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }
    }
}
