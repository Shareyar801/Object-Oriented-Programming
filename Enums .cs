using System;
namespace ConsoleApp1
{
    enum food    // only int values can be stored in enums
    {
        pie = 7,
        pizza, //8
        cones, //9
        ice_creams = 4,
        lollipops = 1
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pie: " + Convert.ToInt32(food.pie));
            Console.WriteLine("Pizza: " + (int)food.pizza);
            Console.WriteLine("Cones: " + (int)food.cones);
            Console.WriteLine("ice_creams: " + Convert.ToInt32(food.ice_creams));
            Console.WriteLine("lollipops: " + Convert.ToInt32(food.lollipops));
            Console.WriteLine();
        }
    }
}
