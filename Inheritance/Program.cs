using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

           Bird bird1 = new Bird();
            bird1.OwnerName = "Sally";
            bird1.Name = "JellyBean";
            bird1.Age = 10;
            bird1.CanFly = true;
            bird1.NumberOfLegs = 2;
            bird1.BirdType = "Parrot";
            bird1.AmountOfFood = 2.5;
            bird1.Diet = "Tropical seeds";
            


            Reptile rep1 = new Reptile();
            rep1.OwnerName = "Jess";
            rep1.Name = "Mr. Jeepers";
            rep1.Age = 3;
            rep1.NumberOfLegs = 3;
            rep1.ReptileType = "Komodo Dragon";
            rep1.CanBite = true;
            rep1.HowLong = 7.5;
            rep1.Diet = "White mice ONLY";
            Console.WriteLine();

            Canine dog1 = new Canine();
            dog1.OwnerName = bird1.OwnerName;
            dog1.Name = "Gus";
            dog1.Age = 4;
            dog1.NumberOfLegs = 4;
            dog1.DogType = "PomChi";
            dog1.NumTimesToWalk = 3;
            dog1.FavToy = "Rope";
            dog1.Diet = "Ceaser Wet Food";

            Console.WriteLine($"{bird1.OwnerName} owns {bird1.Name} and {dog1.Name}.");
            Console.WriteLine($"{bird1.Name} is {bird1.Age} years old and {dog1.Name} is {dog1.Age}.");
            Console.WriteLine($"{bird1.Name} is a {bird1.BirdType} and eats {bird1.AmountOfFood} ounces of {bird1.Diet}.");
            Console.WriteLine($"{dog1.Name} is a {dog1.DogType} and eats one {dog1.Diet} a day.");
            Console.WriteLine($"{dog1.Name} needs to potty {dog1.NumTimesToWalk} times a day and likes to play with his {dog1.FavToy}.");
            Console.WriteLine($"It's {bird1.CanFly} that {bird1.Name} can fly and has {bird1.NumberOfLegs} legs.");
            Console.WriteLine();
            Console.WriteLine($"{rep1.OwnerName} owns {rep1.Name}.");
            Console.WriteLine($"{rep1.Name} is {rep1.Age} years old and only has {rep1.NumberOfLegs} legs but, measures at {rep1.HowLong} feet!");
            Console.WriteLine($"{rep1.Name} is a {rep1.ReptileType} and eats {rep1.Diet}.");
            Console.WriteLine($"Watch out because it is {rep1.CanBite} that {rep1.Name} can bite.");
            Console.WriteLine($"Please feed {rep1.Name} {rep1.Diet}.");




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
