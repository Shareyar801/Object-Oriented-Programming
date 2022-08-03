using System;
namespace ConsoleApp2
{
    //overriding example:

    class Car_Engine01
    {
        public virtual void Engine()
        {
            int pwr_of_eng = 524;
            int rpm = 140;
            int no_of_cyc = 4;
            Console.WriteLine("Virtual Method Called: pwr_of_eng-> " + pwr_of_eng + " rpm-> " + rpm + " no_of_cyc-> " + no_of_cyc);
        }
    }
    class Car_Engine02 : Car_Engine01
    {
        public override void Engine()
        {
            int pwr_of_eng = 410;
            int rpm = 175;
            int no_of_cyc = 3;
            Console.WriteLine("Override Method Called: pwr_of_eng-> " + pwr_of_eng + " rpm-> " + rpm + " no_of_cyc-> " + no_of_cyc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car_Engine01 ce1 = new Car_Engine01();
            Car_Engine01 ce2 = new Car_Engine02();
            ce1.Engine();
            ce2.Engine();
        }
    }
}
