namespace TaskAboutClasses;

public class Animal
{
    public string name;
    public byte age;

    public string Eat()
    {
        return "Able to eat";
    }
}

public class Dog : Animal
{
    public bool hasTail;
    public Dog(string name, byte age, bool hasTail)
    {
       this.name = name;
       this.age = age;
       this.hasTail = hasTail;
    }
    public string Bark()
    {
        return "Dogs are barking!";
    }

    public void GetInfoAboutDog()
    {
        Console.WriteLine($"Information about Dog \nName: {name} \nAge: {age} \nHasTail: {hasTail}");
        Console.WriteLine(Bark());
        Console.WriteLine(Eat());
    }
}

public class Bear : Animal
{
    public bool isWild;
    
    public Bear(string name, byte age, bool isWild)
    {
        this.name = name;
        this.age = age;
        this.isWild = isWild;
    }
    public void GetInfoAboutBear()
    {
        Console.WriteLine($"Information about Bear\nName: {name} \nAge: {age} \nisWild: {isWild}");
        Console.WriteLine(Eat());
    }
}

public class Bird : Animal
{
    public bool canSwim;
    public Bird(string name, byte age, bool canSwim)
    {
        this.name = name;
        this.age = age;
        this.canSwim = canSwim;
    }
    public string Fly()
    {
        return "Fly";
    }
    public void GetInfoAboutBird()
    {
        Console.WriteLine($"Information about Bird \nName: {name} \nAge: {age} \ncanSwim: {canSwim}");
        Console.WriteLine(Fly());
        Console.WriteLine(Eat());
    }
}

