using System;
namespace ConsoleApp2
{
    class Conversion_methods
    {
        public string Convert(int num01)
        {
            string converted_str = num01.ToString();
            return converted_str;
        }
        public string Convert(float num01)
        {
            string converted_str = num01.ToString();
            return converted_str;
        }
        public string Convert(double num01)
        {
            string converted_str = num01.ToString();
            return converted_str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var num01 = 25.98814410;
            var num02 = 25.8710;
            var num03 = 025;
            Conversion_methods cm = new Conversion_methods();
            Console.WriteLine("Int Converted into string: " + cm.Convert(num03) + "\t\t//Convert method with int parameter is called!");
            Console.WriteLine("Float Converted into string: " + cm.Convert(num02) + "\t//Convert method with float parameter is called!");
            Console.WriteLine("Double Converted into string: " + cm.Convert(num01) + "\t//Convert method with double parameter is called!");
        }
    }
}
