using System;
namespace ConsoleApp4
{
    abstract class Animal
    {
        //It is not possible to create an object of the Animal class.
        //Abstract keyword is not for variables.

        int p = 40;

        public abstract void animalSound();     // abstract method

        public void sleep()     // Regular method
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}
