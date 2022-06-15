using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFacade
{
    public class Database
    {
        //list of person which will be populated with hardcoded data
        List<Person> people;

        public Database()
        {
            //initilizing it in constructor
            people = new List<Person>();
            //and calling the SeedData method 
            SeedData();
        }

        //method adding 10 diffrent people to the people list
        private void SeedData()
        {
            people.Add(new Person { Id = IdCalculator(), FirstName = "Peter", LastName = "Petersen", Birthday = new DateTime(2002, 10, 23), Adress = "Holstebrovej 70", City = "Holstebro", ZipCode = 7500, Email = "skr@123skr.com", PhoneNumber = 12345678 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Tim", LastName = "Timsen", Birthday = new DateTime(2001, 8, 16), Adress = "Herningvej 20", City = "Herning", ZipCode = 7400, Email = "ti@ti.com", PhoneNumber = 88888888 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Simon", LastName = "Simonsen", Birthday = new DateTime(2000, 6, 17), Adress = "Ikastvej 55", City = "Ikast", ZipCode = 7480, Email = "si@123si.com", PhoneNumber = 77777777 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Poul", LastName = "Poulsen", Birthday = new DateTime(2010, 8, 2), Adress = "Viborgvej 11", City = "Viborg", ZipCode = 8800, Email = "po@po.com", PhoneNumber = 66666666 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Erik", LastName = "Eriksen", Birthday = new DateTime(1999, 6, 9), Adress = "Skivevej 10", City = "Skive", ZipCode = 7800, Email = "er@er.com", PhoneNumber = 55555555 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Simone", LastName = "Christensen", Birthday = new DateTime(1980, 2, 25), Adress = "Odensenvej 100", City = "Odense", ZipCode = 5000, Email = "si@ch.com", PhoneNumber = 44444444 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Trine", LastName = "Trinesen", Birthday = new DateTime(1987, 4, 19), Adress = "Tøndervej 70", City = "Tønder", ZipCode = 6240, Email = "tr@tr.com", PhoneNumber = 33333333 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Kim", LastName = "Kimsen", Birthday = new DateTime(2020, 11, 18), Adress = "Holstebrovej 70", City = "Holstebro", ZipCode = 7500, Email = "ki@ki.com", PhoneNumber = 22222222 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Laura", LastName = "Laurasen", Birthday = new DateTime(2005, 12, 4), Adress = "Herningvej 75", City = "Herning", ZipCode = 7400, Email = "la@la.com", PhoneNumber = 11111111 });
            people.Add(new Person { Id = IdCalculator(), FirstName = "Ib", LastName = "Ibsen", Birthday = new DateTime(1950, 1, 1), Adress = "Viborgvej 60", City = "Viborg", ZipCode = 8800, Email = "ib@ib.com", PhoneNumber = 56756754 });

        }

        //method returning a list of people with the age 18 to 68
        public List<Person> PeopleList18to68()
        {
            //returning lambda expression finding all people with the age 18 to 68
            //taking the people list and using the FindAll method which will find all specific people
            //giving it a parameter, then the "goes to" to the body expression where we make sure the parameters/persons age is above 18
            //then making sure its also under 68 with &&
            return people.FindAll(p => p.Age >= 18 && p.Age < 68);
        }

        //method returning a count of people born before the passed in year
        public int CountForPeopleBorn(int year)
        {
            //returning lambda expression calculating the amount of people born b4 the passed in year
            //taking the people list and using the Count method finding the count in terms of the expression 
            return people.Count(p => p.Birthday.Year < year);
        } 

        public int PersonWithLowestId()
        {
            return people.Min(p => p.Id);
        }

        public List<Person> PListSorted()
        {
            return people.OrderByDescending(p => p.FirstName).ToList();
        }

        //method calculating the id for the people
        //called in SeedData at every id 
        private int IdCalculator()
        {
            //checking if there is no ids given in the list
            if (people.Count == 0)
            {
                //then return 1 for the first person id
                return 1;
            }

            //if there is 1 or more ids given
            //we return lambda expression calculating the id
            //we take the people list and take the max (meaning the highest number)
            //giving it a parameter for the object in the list and using => as "goes to" to the body expression which is where we find the id
            //so now we have the max id of the list and do a +1 
            return people.Max(skr => skr.Id) +1;
        }
    }
}
