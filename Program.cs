
using AnimalInheritanceExample;

Console.WriteLine("Hello, World!");
Dog dog1 = new Dog { Name = "Rox", IsTrained = true };
Dog dog2 = new Dog { Name = "Rox", IsTrained = false };

Cat cat1 = new Cat { Name = "Posy", CatType = "Siamese" };
Cat cat2 = new Cat { Name = "Mimi", CatType = "Wild" };

Console.WriteLine(dog1);
Console.WriteLine(dog2);
Console.WriteLine(cat1);
Console.WriteLine(cat2);

Console.WriteLine($"Are dog1 and dog2 equal? {dog1.Equals(dog2)}");
Console.WriteLine($"HashCode of dog1: {dog1.GetHashCode()}");
Console.WriteLine($"HashCode of dog2: {dog2.GetHashCode()}");
Console.WriteLine($"Are cat1 and cat2 equal? {cat1.Equals(cat2)}");