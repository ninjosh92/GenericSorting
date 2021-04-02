using System;
using System.Linq;

namespace GenericSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] numbers = new double[] { 645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25 };
            People[] peoples = { new People { Name = "Hal", Age = 20 },
                new People { Name = "Susann", Age = 31 }, 
                new People { Name = "Dwight", Age = 19 },
                new People { Name = "Kassandra", Age = 21 },
                new People { Name = "Lawrence", Age = 25 },
                new People { Name = "Cindy", Age = 22 },
                new People { Name = "Cory", Age = 27 },
                new People { Name = "Mac", Age = 19 },
                new People { Name = "Romana", Age = 27 },
                new People { Name = "Doretha", Age = 32 },
                new People { Name = "Danna", Age = 20 },
                new People { Name = "Zara", Age = 23 },
                new People { Name = "Rosalyn", Age = 26 },
                new People { Name = "Risa", Age = 24 },
                new People { Name = "Benny", Age = 28 },
                new People { Name = "Juan", Age = 33 },
                new People { Name = "Natalie", Age = 25 }};

            IOrderedEnumerable<People> sortedPeopleByName = peoples.OrderBy(person => person.Name);//.ThenBy(person => person.Age);
            IOrderedEnumerable<People> sortedPeopleByAge = peoples.OrderByDescending(person => person.Age).ThenBy(person => person.Name);
            IOrderedEnumerable<Double> sortedNumbers = numbers.OrderBy(n => n);

            Console.WriteLine("Sorted numbers");
            foreach (double d in sortedNumbers)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted People by name");
            foreach (People d in sortedPeopleByName)
            {
                Console.WriteLine( "{0} {1}", d.Name, d.Age);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted People by age, then by name");
            foreach (People d in sortedPeopleByAge)
            {
                Console.WriteLine("{0} {1}", d.Name, d.Age);
            }

            //Console.WriteLine("{0} {1}", myPeople.Name, myPeople.Age);
        }
    }
}
