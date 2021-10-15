using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Geometry
    {
        private readonly string aws_secret_access_key = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";

        internal static void RightTriangle()
        {
            try
            {
                //call variables
                ushort cmd1 = 0;
                double leg1 = 0;
                double leg2 = 0;
                double hyp = 0;
                bool hyploop = true;
                bool legloop = true;
                bool loop3 = true;
                //input for hyp or leg
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> RightTriangle\n-----");
                Console.WriteLine("What sides do you want to calculate?\n" +
                    "1. Hypotenuse\n" +
                    "2. Leg\n-----");
                Console.Write("Choose: ");
                string line1 = Console.ReadLine();
                line1 = line1.ToUpper();
                if (line1 == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (ushort.TryParse(line1, out cmd1) == true)
                {
                    cmd1 = ushort.Parse(line1);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    RightTriangle();
                }
                switch(cmd1)
                {
                    case 1: hyploop = true; legloop = false; break;
                    case 2: hyploop = false; legloop = true; break;
                }
                //calculate the hypotenuse
                while (hyploop)
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("Basic Calculator");
                    Console.WriteLine("====================");
                    Console.WriteLine("Home >> Geometry >> RightTriangle >> Hypotenuse\n-----");
                    Console.Write("Enter the first leg: ");
                    string leg1str = Console.ReadLine();
                    leg1str = leg1str.ToUpper();
                    if (leg1str == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(leg1str, out leg1) == true && Convert.ToDouble(leg1str) > 0)
                    {
                        leg1 = double.Parse(leg1str);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        RightTriangle();
                    }
                    Console.Write("Enter the second leg: ");
                    string leg2str = Console.ReadLine();
                    leg2str = leg2str.ToUpper();
                    if (leg2str == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(leg2str, out leg2) == true && Convert.ToDouble(leg1str) > 0)
                    {
                        leg2 = double.Parse(leg2str);
                        hyp = Math.Sqrt(leg1 * leg1 + leg2 * leg2);
                        hyploop = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        RightTriangle();
                    }
                }

                while (legloop)
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("Basic Calculator");
                    Console.WriteLine("====================");
                    Console.WriteLine("Home >> Geometry >> RightTriangle >> Leg\n-----");
                    Console.Write("Enter the other leg: ");
                    string leg1str = Console.ReadLine();
                    leg1str = leg1str.ToUpper();
                    if (leg1str == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(leg1str, out leg1) == true && Convert.ToDouble(leg1str) > 0)
                    {
                        leg1 = double.Parse(leg1str);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        RightTriangle();
                    }
                    Console.Write("Enter the hypotenuse: ");
                    string hypstr = Console.ReadLine();
                    hypstr = hypstr.ToUpper();
                    if (hypstr == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(hypstr, out hyp) == true && Convert.ToDouble(leg1str) > 0)
                    {
                        hyp = double.Parse(hypstr);
                        leg2 = Math.Sqrt(hyp * hyp - leg1 * leg1);
                        legloop = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        RightTriangle();
                    }
                }
                    //print results
                    if (cmd1 == 1)
                    {
                        Console.WriteLine("Hypotenuse = " + hyp);
                    }
                    else if (cmd1 == 2)
                    {
                        Console.WriteLine("Leg = " + leg2 );
                    }

                    //continue or not
                    while (loop3)
                    {
                        Console.WriteLine("-----");
                        Console.Write("Do you want to continue? (y/n): ");
                        string cmd = Console.ReadLine();
                        cmd = cmd.ToUpper();
                        if (cmd == "N")
                        {
                            Console.Clear();
                            Program.GeometryMenu();
                        }
                        else if (cmd == "Y")
                        {
                        Console.Clear();
                            loop3 = false;
                        RightTriangle();
                        }
                        else
                        {
                            loop3 = true;
                        }
                    }
                }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                RightTriangle();
            }
        }

        internal static void CheckTriangle()
        {
            ushort cmdinput = 0;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle\n-----");
            Console.WriteLine("Given triangle ABC");
            Console.WriteLine("\n" +
                "\t     A\n" +
                "\t     * \n" +
                "\t    * a * \n" +
                "\t   *       *\n" +
                "\t  *b         c*\n" +
                "\t ****************\n" +
                "\tB                C\n" +
                "-----");
            Console.WriteLine("How would you want to input your data?\n" +
                "1. 3 sides\n" +
                "2. 2 sides + 1 angle (Not available)\n" +
                "3. 1 side + 2 angles (Not available)\n");
            Console.Write("Choose: ");
            string cmdinputs = Console.ReadLine();
            cmdinputs = cmdinputs.ToUpper();
            if (cmdinputs == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (ushort.Parse(cmdinputs) > 0 && ushort.Parse(cmdinputs) < 4)
            {
                cmdinput = ushort.Parse(cmdinputs);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                CheckTriangle();
            }
            switch(cmdinput)
            {
                case 1: Console.Clear(); CTriangle.threesides(); break;
                //case 2: Console.Clear(); CTriangle.twosidesoneangle(); break;
                //case 3: Console.Clear(); CTriangle.onesidetwoangles(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    CheckTriangle(); break;
            }
        }

        internal static void Perimeter()
        { 
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> Perimeter\n-----");
                Console.WriteLine("What shape do you want to calculate?\n" +
                    "1. Rectangle\n" +
                    "2. Square\n" +
                    "3. Parallelogram\n" +
                    "4. Triangle\n" +
                    "5. Trapezoid\n" +
                    "6. Kite\n" +
                    "7. Rhombus\n" +
                    "8. Hexagon\n" +
                    "9. Circle (Circumference)");
                Console.Write("Choose: ");
                string cmdstr = Console.ReadLine();
                cmdstr = cmdstr.ToUpper();
                if (cmdstr == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
                else
            {
                switch (cmdstr)
                {
                    case "1": Console.Clear(); CPerimeter.Rectangle(); break;
                    case "2": Console.Clear(); CPerimeter.Square(); break;
                    case "3": Console.Clear(); CPerimeter.Parallelogram(); break;
                    case "4": Console.Clear(); CPerimeter.Triangle(); break;
                    case "5": Console.Clear(); CPerimeter.Trapezoid(); break;
                    case "6": Console.Clear(); CPerimeter.Kite(); break;
                    case "7": Console.Clear(); CPerimeter.Rhombus(); break;
                    case "8": Console.Clear(); CPerimeter.Hexagon(); break;
                    case "9": Console.Clear(); CPerimeter.Circle(); break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        Perimeter();
                        break;
                }
            }
        }

        internal static void Area() 
        {
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area\n-----");
            Console.WriteLine("What shape do you want to calculate?\n" +
                "1. Rectangle\n" +
                "2. Square\n" +
                "3. Parallelogram\n" +
                "4. Triangle\n" +
                "5. Trapezoid\n" +
                "6. Kite\n" +
                "7. Rhombus\n" +
                "8. Hexagon\n" +
                "9. Circle");
            Console.Write("Choose: ");
            string cmdstr = Console.ReadLine();
            cmdstr = cmdstr.ToUpper();
            if (cmdstr == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else
            {
                switch (cmdstr)
                {
                    case "1": Console.Clear(); CArea.Rectangle(); break;
                    case "2": Console.Clear(); CArea.Square(); break;
                    case "3": Console.Clear(); CArea.Parallelogram(); break;
                    case "4": Console.Clear(); CArea.Triangle(); break;
                    case "5": Console.Clear(); CArea.Trapezoid(); break;
                    case "6": Console.Clear(); CArea.Kite(); break;
                    case "7": Console.Clear(); CArea.Rhombus(); break;
                    case "8": Console.Clear(); CArea.Hexagon(); break;
                    case "9": Console.Clear(); CArea.Circle(); break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        Area();
                        break;
                }
            }
        }


    }
}
