namespace TaskAboutClasses;

class Program
{
    static void Main(string[] args)
    {
        string animalInput;
        while (true)
        {
            Console.Write("Please choose animal: ");
            animalInput = Console.ReadLine();
            if (animalInput == "dog" || animalInput == "bear" || animalInput == "bird")
            {
                if (animalInput == "dog")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    string dogName;
                    byte dogAge;
                    bool hasTail;
                    
                    Console.Write("Please enter the name of the dog: ");
                    dogName = Console.ReadLine();
                    Console.Write("Please enter the age of the dog: ");
                    dogAge = byte.Parse(Console.ReadLine());
                    Console.Write("please enter about tail of the dog: ");
                    hasTail = bool.Parse(Console.ReadLine());
                    
                    Dog dogObj = new Dog(dogName, dogAge, hasTail);
                    Console.WriteLine("---------------------------------------------------");
                    dogObj.GetInfoAboutDog();
                    break;
                }
                else if (animalInput == "bear")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    string bearName;
                    byte bearAge;
                    bool isWild;
                    
                    Console.Write("Please enter the name of the bear: ");
                    bearName = Console.ReadLine();
                    Console.Write("Please enter the age of the bear: ");
                    bearAge = byte.Parse(Console.ReadLine());
                    Console.Write("please enter about wild or not this bear: ");
                    isWild = bool.Parse(Console.ReadLine());

                    Bear bearObj = new Bear(bearName, bearAge, isWild);
                    Console.WriteLine("---------------------------------------------------");
                    bearObj.GetInfoAboutBear();
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    string birdName;
                    byte birdAge;
                    bool canSwim;
                    
                    Console.Write("Please enter the name of the bird: ");
                    birdName = Console.ReadLine();
                    Console.Write("Please enter the age of the bird: "); 
                    birdAge = byte.Parse(Console.ReadLine());
                    Console.Write("Please enter is this bird can swim: ");
                    canSwim = bool.Parse(Console.ReadLine()); 
                    
                    Bird birdObj = new Bird(birdName, birdAge, canSwim);
                    Console.WriteLine("---------------------------------------------------");
                    birdObj.GetInfoAboutBird();
                    break;
                }
            }
            else
            {
                continue;
            }
        } 
    }
}
