using CTDay2;
Console.WriteLine("Hello, World!");
Cat Cadife = new Cat("Cadife", 'F', "Calico");
Cadife.Move();
string name = "Cadife";

Cat Annie = new("Annie") { Gender = 'F'};

Cat Annie2 = new();
Annie2.Name = "Annie";
Annie2.Gender = 'F';
Console.WriteLine(Annie2.Gender);
string binomialname = Cat.BinomialName;
Cat.PrintBinomialName();
Console.WriteLine(PetShop.Name);

Cat2 mycat = new() { Name = "Cadife", Gender = 'F' };
mycat.PrintName();

mycat.PrintGreeting();
mycat.PrintBaseGreeting();

Mamba mamba = new() { Gender = 'M' };
Snake cornSnake = new CornSnake();
Console.WriteLine(cornSnake.Poisonous);
Animal animal = cornSnake;
animal.Eat(100);



