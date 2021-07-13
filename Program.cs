using System;
using System.Threading;
namespace BasicCalculator
{
    class Program
    {
        static void About()
        {
            // start of about
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> About");
            Console.WriteLine("----------About----------\n" +
                "* Basic Calculator v0.1 BETA \n" +
                "* Mini project by domcvn\n" +
                "----------Updates----------\n" +
                "- The first release of the basic calculator!\n" +
                "- Program based on Console\n" +
                "---Plan for next release---\n" +
                "- Try to figure out the triangle part\n" +
                "- Fix some more errors and bugs");
            //end of about
            Console.Write("Enter \"menu\" to go back to Main Menu: ");
            string line = Console.ReadLine();
            line = line.ToUpper();
            if (line == "MENU")
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                About();
            }
        }
        public static void Help()
        {
            //start help
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Help \n");
            Console.WriteLine("============ H E L P & F A Q ============");
            Console.WriteLine("Where some of your frequently asked questions are located. Type the help number to see more information. Type \"menu\" to go back to main menu.\n----------");
            Console.WriteLine("1. To go back to the branch, use the command \"done\" when it's requiring user input. This does not applies for y/n question.");
            Console.WriteLine("2. There are some additional prefixes for Algebra Basic Maths.");
            Console.WriteLine("3. In quadratic equations, sometimes the returning results (x1, x2) are NaN. Why?\n" +
                "4. Why does it take so long to return results?");
            //end help, start command
            Console.Write("----------\nEnter command: ");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "menu": Console.Clear(); MainMenu(); break;
                case "1": Console.Clear(); HelpSpecific.BranchReturn(); break;
                case "2": Console.Clear();  HelpSpecific.MathPrefixes(); break;
                case "3": Console.Clear(); HelpSpecific.QuadReturn(); break;
                default: Console.Clear(); Console.WriteLine("Invalid command"); Help(); break;
            }
        }
        public static void AlgebraMenu()
        {
            bool loop = true;
            short cmd = -1;
            while (loop)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Algebra");
                Console.WriteLine("-----");
                Console.WriteLine("0. Go back\n" +
                    "1. Calculate with + - * /\n" +
                    "2. Solve for x in quadratic formula\n" +
                    "3. Find power of a number\n" +
                    "4. Find root of a number\n" +
                    "5. Find factorial of a number\n" +
                    "6. Print PI\n" +
                    "7. Find Great Common Divisor (GCD)\n" +
                    "8. Find Least Common Multiple (LCM)\n" +
                    "9. Find Arithmetic Mean\n" +
                    "10. Find Geometric Mean");
                Console.WriteLine("-----");
                Console.Write("Choose: ");
                try
                {
                    cmd = short.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Command");
                    loop = false;
                }
                if (cmd >= 0 && cmd <= 10)
                {
                    loop = false;
                    Console.Clear();
                }
                else
                {
                    loop = true;
                    Console.Clear();
                    Console.WriteLine("Invalid Command");
                }
            }

            //commands
            switch(cmd)
            {
                case 0: MainMenu(); break;
                case 1: Algebra.BasicOperators(); break;
                case 2: Algebra.Quadratic(); break;
                case 3: Algebra.Power(); break;
                case 4: Algebra.Root(); break;
                case 5: Algebra.Factorial(); break;
                case 6: Algebra.Pi(); break;
                case 7: Algebra.GCD(); break;
                case 8: Algebra.LCM(); break;
                case 9: Algebra.ArithmeticMean(); break;
                case 10: Algebra.GeometricMean(); break;
            }
        }
        public static void GeometryMenu()
        {
            bool loop = true;
            short cmd = -1;
            while (loop)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry");
                Console.WriteLine("-----");
                Console.WriteLine("0. Go back\n" +
                    "1. Calculate the remaining sides / angles of a triangle (Experimental)\n" +
                    "2. Calculate the hypotenuse / leg of a right triangle\n" +
                    "3. Calculate the Perimeter of 2D shapes\n" +
                    "4. Calculate the Area of 2D shapes");
                Console.WriteLine("-----");
                Console.Write("Choose: ");
                cmd = short.Parse(Console.ReadLine());
                if (cmd >= 0 && cmd <= 4)
                {
                    loop = false;
                }
                else
                {
                    loop = true;
                    Console.Clear();
                    Console.WriteLine("Invalid Command");
                }
            }
            switch (cmd)
            {
                case 0: Console.Clear(); MainMenu(); break;
                case 1: Console.Clear(); Geometry.CheckTriangle(); break;
                case 2: Console.Clear(); Geometry.RightTriangle(); break;
                case 3: Console.Clear(); Geometry.Perimeter(); break;
                case 4: Console.Clear(); Geometry.Area(); break;
            }
        }
        static void MainMenu()
        {
            bool loop = true;
            short cmd = -1;
            while (loop)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home");
                Console.WriteLine("---");
                Console.WriteLine("0. Quit the program");
                Console.WriteLine("1. Algebra");
                Console.WriteLine("2. Geometry");
                Console.WriteLine("3. Trigonometry / Calculus (Not available)");
                Console.WriteLine("4. Help");
                Console.WriteLine("5. About");
                Console.WriteLine("---");
                Console.Write("Choose: ");
                try
                {
                    cmd = short.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Command");
                }
                if (cmd >= 0 && cmd <= 5)
                {
                    loop = false;
                    Console.Clear();
                }
                else
                {
                    loop = true;
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                }
            }
            if (cmd == 1)
            {
                AlgebraMenu();
            }
            else if (cmd == 2)
            {
                GeometryMenu();
            }
            else if (cmd == 3)
            {
                Console.Clear();
                Console.WriteLine("Trigonometry / Calculus is not available yet!");
                MainMenu();
            }
            else if (cmd == 5)
            {
                Console.Clear();
                About();
            }
            else if (cmd == 4)
            {
                Console.Clear();
                Help();
            }
            else if (cmd == 0)
            {
                bool loopquit = true;
                while (loopquit) {
                    Console.Clear();
                    Console.Write("Are you sure you want to quit? (y/n): ");
                    string cmd2 = Console.ReadLine();
                    cmd2 = cmd2.ToUpper();
                    if (cmd2 == "N")
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    if (cmd2 == "Y")
                    {
                        Console.WriteLine("Thank you for using the calculator, the app will automatically exit in 1 second.");
                        Thread.Sleep(1000);
                        loopquit = false;
                        Environment.Exit(0);
                    }
                    else {
                        loopquit = true;
                    }
                }
            }
            loop = true;
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
