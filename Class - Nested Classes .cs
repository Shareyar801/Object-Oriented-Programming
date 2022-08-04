using System;
namespace ConsoleApp
{
    class outermost_shell
    {
        //public Nested(Container parent) { } what is container parent?

        public void outer_box_reached()
        {
            Console.WriteLine("Method in outer most class is reached!");
        }

        public class middle_shell
        {
            public void mid_shell_reached()
            {
                Console.WriteLine("Method in middle class is reached!");
            }

            protected interface mostinner_shell
            {
                public void inner_shell_reached() { }
            }

            public class mostinner_shell2 : mostinner_shell
            {
                public mostinner_shell2() 
                {
                    Console.WriteLine("Constructor in inner most class is reached!");
                }

                public void inner_shell_reached()
                {
                    Console.WriteLine("Method in inner most class is reached!");

                }
            }

        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //creating object of main/outer class 
            outermost_shell B = new outermost_shell();
            B.outer_box_reached();

            //creating object of nested01/middle class 
            outermost_shell.middle_shell nest01 = new outermost_shell.middle_shell();
            nest01.mid_shell_reached();

            //creating object of nested02/inner class 
            outermost_shell.middle_shell.mostinner_shell2 nest02 = new outermost_shell.middle_shell.mostinner_shell2();
            nest02.inner_shell_reached();

        }
    }
}
