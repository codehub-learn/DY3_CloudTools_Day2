using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Cat
    {
        public string Name;
        public string Breed;
        public char Gender;
        public DateTime insertionDate;

        public Cat(string name, string breed, char gender)
        {
            Name = name;
            Gender = gender;
            Breed = breed;
            insertionDate = DateTime.Now;
        }

        public Cat()
        {
            insertionDate = DateTime.Now;  s
        }

        public void Mew()
        {
            Console.WriteLine($"{Name} has mewed");
        }
    }
}
