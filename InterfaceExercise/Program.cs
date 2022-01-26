using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSay hello to my biggle (all rights reserved on this term) car garage - info session style :-):\n");

            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("----------------------------------\n");

            var car = new Car();
            Console.WriteLine($"First up is my car, I call her Sweet P. {car.MainPurpose} she's my go-to vehicle for running errnands, and attending events." +
                $"She came to yours truly from a loving home at {car.Make} courtesy of the {car.CompanyHeadCount} souls who work at {car.CompanyName} and originally named her '{car.Model}'" +
                $"when she was brought into the world back in {car.Year}. In case you're wondering, I definitely got her dad and company leader {car.CompanyLeader}'s permission to take her home.\n");
            Console.WriteLine("----------------------------------\n");

            var suv = new SUV();
            Console.WriteLine($"Next up is my SUV. I call her Sweet Potato P. {suv.ReasonWhyMade} Sweet Potato P is my go-to vehicle for long distance drives." +
                $"Like her sister {car.Model}, she also came to yours truly from a loving home at {car.Make} courtesy of the {suv.CompanyHeadCount} souls who work at {suv.CompanyName} and originally named her '{suv.Model}'" +
                $"when she was brought into the world back in {suv.Year}. Yup, I also got her dad and company leader {suv.CompanyLeader}'s permission to add her to my family.\n");
            Console.WriteLine("----------------------------------\n");

            var truck = new Truck();
            Console.WriteLine($"Last but not least is my truck, I call her Senator Karen and she can be a mean bitch. {truck.FunctionalPurpose} She's my go-to vehicle for heavy duty get dirty with it work. " +
                $"Senator Karen resembles a Tacoma but never claimed Native American and I respect that." +
                $"She came me from a loving home at {truck.Make} courtesy of the {truck.CompanyHeadCount} souls who work at {truck.CompanyName} and originally named her the '{truck.Model}'" +
                $"when she made her debut back in {truck.Year}. Like her siblings, her addition to my garage was approved by {truck.CompanyLeader} before her departure.\n");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("Thank you guys for checking out my crib. You ain't gotta go home but you gotta GTFOH ... PEACE and LOVE :-)!\n");
        }
    }
}
