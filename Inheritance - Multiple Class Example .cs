using System;
namespace ConsoleApp1
{
    public interface Ivehicle
    {
        public void start();
        public void run();
        public void stop();
        
    }
    public interface Icar
    {
        abstract public void engine();
        abstract public void air_condition();
    }
    class audi : Ivehicle, Icar
    {
        public void start() 
        {
            Console.WriteLine("Car will start.");
        }
        public void run()
        {
            Console.WriteLine("Car will run.");
        }
        public void engine()
        {
            Console.WriteLine("Car engine will start.");
        }
        public void air_condition()
        {
            Console.WriteLine("Car ac will start.");
        }
        public void stop()
        {
            Console.WriteLine("Car will stop.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            audi a01 = new audi();
            a01.start();
            a01.run();
            a01.engine();
            a01.air_condition();
            a01.stop();

            Console.WriteLine();
        }
    }
}
