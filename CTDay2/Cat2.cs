using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    internal class Cat2 : Animal
    {
        public string Breed { get; set; }
        public string Greeting { get; } = "Hello from Cat!";
        public Cat2(string name, char gender, string breed) : base(name, gender)
        {
            Breed = breed;
        }

        public Cat2() 
        { 
        }

        public void PrintGreeting() 
        {
            Console.WriteLine(Greeting);
        }

        public void PrintBaseGreeting()
        {
            Console.WriteLine(base.Greeting);
        }

        public override void Eat(int volume)
        {
            Console.WriteLine($"The cat has eaten {volume}");
        }
    }
}
