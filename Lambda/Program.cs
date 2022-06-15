// See https://aka.ms/new-console-template for more information


using CLFacade;

//instance of the Database class 
//using this variable to get methods finding people through lambda
Database db = new Database();

//initializing a new list of persons
//this list will contain the list of people sorted by lambda in DB later
List<Person> LP = new List<Person>();

//Find people 
LP = db.PeopleList18to68();

foreach (var item in LP)
{
    Console.WriteLine($"{item.Age}, {item.FirstName}, {item.Birthday.ToShortDateString()}");
}

//Find count of people born before the parameter
Console.WriteLine("\n" + db.CountForPeopleBorn(2000));

//Find Lowest id in the list
Console.WriteLine("\n" + db.PersonWithLowestId() + "\n");

//Find people sorted descending
LP = db.PListSorted();
foreach (var item in LP)
{
    Console.WriteLine($"{item.Id}, {item.FirstName}");
}

Console.WriteLine("hey");