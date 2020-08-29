using System;
using System.Collections.Generic;

namespace DocumentationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Documentation Exercise");


            // Working with numbers
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("The list numbers contains:");
            ListOperations.Print(numbers);

            Console.WriteLine($"Its average is: {ListOperations.Average(numbers)}");

            ListOperations.DoThingOne(numbers);
            Console.WriteLine("After invoking DoThingOne() on numbers, it contains:");
            ListOperations.Print(numbers);

            ListOperations.DoThingTwo(numbers);
            Console.WriteLine("After invoking DoThingTwo() on numbers, it contains:");
            ListOperations.Print(numbers);

            ListOperations.DoThingThree(numbers);
            Console.WriteLine("After invoking DoThingThree() on numbers, it contains:");
            ListOperations.Print(numbers);


            // Working with Fruits
            List<string> fruits = new List<string>() { "Apple", "Bannana", "Cherry", "Grape", "Kiwi", "Orange", "Watermellon" };
            Console.WriteLine("The list fruits contains:");
            ListOperations.Print(fruits);

            ListOperations.DoThingOne(fruits);
            Console.WriteLine("After invoking DoThingOne() on fruits, it contains:");
            ListOperations.Print(fruits);

            ListOperations.DoThingTwo(fruits);
            Console.WriteLine("After invoking DoThingTwo() on fruits, it contains:");
            ListOperations.Print(fruits);

            ListOperations.DoThingThree(fruits);
            Console.WriteLine("After invoking DoThingThree() on fruits, it contains:");
            ListOperations.Print(fruits);


            // Working with an empty list
            List<string> empty = new List<string>();
            Console.WriteLine("The list empty contains:");
            ListOperations.Print(empty);

            ListOperations.DoThingOne(empty);
            Console.WriteLine("After invoking DoThingOne() on empty, it contains:");
            ListOperations.Print(empty);

            ListOperations.DoThingTwo(empty);
            Console.WriteLine("After invoking DoThingTwo() on empty, it contains:");
            ListOperations.Print(empty);

            ListOperations.DoThingThree(empty);
            Console.WriteLine("After invoking DoThingThree() on empty, it contains:");
            ListOperations.Print(empty);

            try
            {
                ListOperations.Average(empty);
            } 
            catch (Exception e)
            {
                Console.WriteLine($"Invoking Average on empty throws a {e}");
            }

            // Working with planets 
            List<Planet> planets = new List<Planet>()
            {
                new Planet("Mercury", 0.3929, 0.0562, 0.0553, 0.377),
                new Planet("Venus", 0.9499, 0.857, 0.815, 0.905),
                new Planet("Earth", 1, 1, 1, 1),
                new Planet("Mars", 0.532, 0.151, 0.107, 0.379),
                new Planet("Jupiter", 10.97, 1321, 317.83, 2.528),
                new Planet("Saturn", 9.140, 764, 95.162, 1.065),
                new Planet("Uranus", 3.981, 63.1, 14.536, 0.886),
                new Planet("Neptune", 3.865, 57.7, 17.147, 1.137),
                new Planet("Pluto", 0.187, 0.00651, 0.0022, 0.063)
            };
            Console.WriteLine("The list planets contains:");
            ListOperations.Print(planets);

            ListOperations.DoThingOne(planets);
            Console.WriteLine("After invoking DoThingOne() on planets, it contains:");
            ListOperations.Print(planets);

            ListOperations.DoThingTwo(planets);
            Console.WriteLine("After invoking DoThingTwo() on planets, it contains:");
            ListOperations.Print(planets);

            ListOperations.DoThingThree(planets);
            Console.WriteLine("After invoking DoThingThree() on planets, it contains:");
            ListOperations.Print(planets);
        }
    }
}
