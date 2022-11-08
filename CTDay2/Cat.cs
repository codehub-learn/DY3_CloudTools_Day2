namespace CTDay2
{
    internal class Cat
    {
        public string Name { get; set; }
       
        private char _gender;
        public char Gender
        {
            get => Gender = _gender;
            set
            {
                if (value != 'F' && value != 'M') Console.WriteLine("Gender must be M of F");
                else _gender = value;
            }
        }
    public string Breed { get; set; }

        public int Move()
        {
            Console.WriteLine($"{Name} has moved!");
            return new Random().Next();
        }

        public int Move(int distance)
        {
            Console.WriteLine($"{Name} has moved {distance}!");
            return new Random().Next();
        }

        public void Sit(int min, string location, string name)
        {
            Console.WriteLine($"{Name} has sat for {min} minutes in {location}!");
        }


        public void Mew()
        {
            Console.WriteLine($"{Name} has mewed!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} has fallen asleep!");
        }

        public Cat(string name, char gender, string breed)
        { 
            Name = name;
            Gender = gender;
            Breed = breed;
        }

        public Cat(string name)
        {
            Name = name;
        }

        public Cat()
        {
        }
    }
}
