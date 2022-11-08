using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Dog
    {
        public string Name;
        public string Breed;
        public char Gender;
        public DateTime insertionDate;

        public Dog(string name, string breed, char gender)
        {
            Name = name;
            Gender = gender;
            Breed = breed;
            insertionDate = DateTime.Now;
        }

        public Dog()
        {
            insertionDate = DateTime.Now;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} has barked");
        }
    }
}
