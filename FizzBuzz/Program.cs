using System;
using System.Collections.Generic;
using FizzBuzz.Components;
using FizzBuzz.Components.Entities;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add any number of divisors/text pairs to be passed in to the method
            //Add unit test to the project
            //Upload to GitHub and send URL to James
            var combinations = new List<Combination>
            {
                new Combination {Divisor = 3, Text = "Fizz"},
                new Combination {Divisor = 5, Text = "Buzz"},
                //new Combination {Divisor = 7, Text = "Fizzle"},
                //new Combination {Divisor = 10, Text = "Deca"}
            };

            var output = FizzBuzzIterator.IterateLoop(combinations);            
            Console.Write(output);
            Console.ReadLine();
        }
    }
}
