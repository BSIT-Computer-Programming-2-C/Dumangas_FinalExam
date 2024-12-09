using System;

namespace AnimalSounds
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dog: Worffff! Worfffff1");
            Console.ResetColor();
        }

    }
    public class Cat : Animal
    {

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cat: Meowwwwwww! Meowwwwwww!");
            Console.ResetColor();
        }
    }

    public class Jearon : Animal
    {
        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jearon: Oinkkkkk!, Oinkkkk!");
            Console.ResetColor();
        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal myJea = new Jearon();
            myDog.MakeSound();
            myCat.MakeSound();
            myJea.MakeSound();



        }

    }
}
