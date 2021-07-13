using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class CArea : Geometry
    {
        protected internal static void Rectangle()
        {
            double length = 0;
            double width = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Rectangle\n-----");
            Console.WriteLine("Formula: length * width");
            Console.WriteLine("-----");
            Console.Write("Enter length: ");
            string slength = Console.ReadLine();
            slength = slength.ToUpper();
            if (slength == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(slength, out length) == true)
            {
                length = double.Parse(slength);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rectangle();
            }
            Console.Write("Enter width: ");
            string swidth = Console.ReadLine();
            swidth = swidth.ToUpper();
            if (swidth == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(swidth, out width) == true)
            {
                width = double.Parse(swidth);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rectangle();
            }

            //output
            Console.Clear();
            ans = length * width;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Rectangle\n-----");
            Console.WriteLine("Formula: length * width");
            Console.WriteLine("Result: {0} * {1} = {2}", length, width, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Square()
        {
            //input
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Square\n-----");
            Console.WriteLine("Formula: side ^ 2");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Square();
            }

            //output
            ans = side * side;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Square\n-----");
            Console.WriteLine("Formula: side ^ 2");
            Console.WriteLine("Result: {0} ^ 2 = {1}", side, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Parallelogram()
        {
            //input
            double bas = 0;
            double height = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Parallelogram\n-----");
            Console.WriteLine("Formula: base * height");
            Console.WriteLine("-----");
            Console.Write("Enter base: ");
            string sbase = Console.ReadLine();
            sbase = sbase.ToUpper();
            if (sbase == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sbase, out bas) == true)
            {
                bas = double.Parse(sbase);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Parallelogram();
            }
            Console.Write("Enter height: ");
            string sheight = Console.ReadLine();
            sheight = sheight.ToUpper();
            if (sheight == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sheight, out height) == true)
            {
                height = double.Parse(sheight);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Parallelogram();
            }

            //output
            ans = bas * height;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Parallelogram\n-----");
            Console.WriteLine("Formula: base * height");
            Console.WriteLine("Result: {0} * {1} = {2}", bas, height, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Triangle()
        {
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Triangle\n-----");
            Console.WriteLine("Which formula do you want to use?");
            Console.WriteLine("1. (base * height) / 2");
            Console.WriteLine("2. p * (p - a) * (p - b) * (p - c)\n-----");
            Console.Write("Choose: ");
            string cmd1 = Console.ReadLine();
            cmd1 = cmd1.ToUpper();
            if (cmd1 == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }

            else if (cmd1 == "1")
            {
                double a = 0;
                double b = 0;
                double ans = 0;
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> Area >> Triangle\n-----");
                Console.WriteLine("Formula: (base * height) / 2");
                Console.WriteLine("-----");
                Console.Write("Enter base: ");
                string sa = Console.ReadLine();
                sa = sa.ToUpper();
                if (sa == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sa, out a) == true)
                {
                    a = double.Parse(sa);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }

                Console.Write("Enter height: ");
                string sb = Console.ReadLine();
                sb = sb.ToUpper();
                if (sb == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sb, out b) == true)
                {
                    b = double.Parse(sb);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }
                //output
                Console.Clear();
                ans = (a * b) / 2;
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> Area >> Triangle\n-----");
                Console.WriteLine("Formula: (base * height) / 2");
                Console.WriteLine("Result: ({0} * {1}) / 2 = {2}", a, b, ans);
            }

            else if (cmd1 == "2")
            {
                double p = 0;
                double a = 0;
                double b = 0;
                double c = 0;
                double ans = 0;
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> Area >> Triangle\n-----");
                Console.WriteLine("Formula: p * (p - a) * (p - b) * (p - c)");
                Console.WriteLine("Note: p: half perimeter; a, b, c: sides");
                Console.WriteLine("-----");
                Console.WriteLine("Enter perimeter");
                string sp = Console.ReadLine();
                sp = sp.ToUpper();
                if (sp == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sp, out p) == true)
                {
                    p = double.Parse(sp);
                    p = p / 2;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }

                Console.Write("Enter side: ");
                string sa = Console.ReadLine();
                sa = sa.ToUpper();
                if (sa == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sa, out a) == true)
                {
                    a = double.Parse(sa);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }

                Console.Write("Enter base: ");
                string sb = Console.ReadLine();
                sb = sb.ToUpper();
                if (sb == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sb, out b) == true)
                {
                    b = double.Parse(sb);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }

                Console.Write("Enter side: ");
                string sc = Console.ReadLine();
                sc = sc.ToUpper();
                if (sc == "DONE")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (double.TryParse(sc, out c) == true)
                {
                    c = double.Parse(sc);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Triangle();
                }

                //output
                Console.Clear();
                ans = p * (p - a) * (p - b) * (p - c);
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> Area >> Triangle\n-----");
                Console.WriteLine("Formula: p * (p - a) * (p - b) * (p - c)");
                Console.WriteLine("Note: p: half perimeter; a, b, c: sides");
                Console.WriteLine("Result: {0} * ({0} - {1}) * ({0} - {2}) * ({0} * {3}) = {4}", p, a, b, c, ans);

                //ask
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
                        Area();
                    }
                    else
                    {
                        loop3 = true;
                    }
                }
            }
            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Trapezoid()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Trapezoid\n-----");
            Console.WriteLine("Formula: ((base + base) / 2) * h");
            Console.WriteLine("-----");
            Console.Write("Enter base: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }

            Console.Write("Enter base: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }

            Console.Write("Enter height: ");
            string sc = Console.ReadLine();
            sc = sc.ToUpper();
            if (sc == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sc, out c) == true)
            {
                c = double.Parse(sc);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }
            //output
            ans = ((a+b)/2)*c;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Trapezoid\n-----");
            Console.WriteLine("Formula: ((base + base)/2)*h");
            Console.WriteLine("Result: (({0} + {1}) / 2) * {2} = {3}", a, b, c, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Kite()
        {
            double a = 0;
            double b = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Kite\n-----");
            Console.WriteLine("Formula: (diagonal * diagonal) / 2");
            Console.WriteLine("-----");
            Console.Write("Enter diagonal: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Kite();
            }
            Console.Write("Enter diagonal: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Kite();
            }

            //output
            ans = (a * b) / 2;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Kite\n-----");
            Console.WriteLine("Formula: (diagonal * diagonal) / 2");
            Console.WriteLine("Result: ({0} * {1}) / 2 ", a, b, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Rhombus()
        {
            double a = 0;
            double b = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Rhombus\n-----");
            Console.WriteLine("Formula: (diagonal * diagonal) / 2");
            Console.WriteLine("-----");
            Console.Write("Enter diagonal: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rhombus();
            }
            Console.Write("Enter diagonal: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rhombus();
            }

            //output
            ans = (a * b) / 2;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Rhombus\n-----");
            Console.WriteLine("Formula: (diagonal * diagonal) / 2");
            Console.WriteLine("Result: ({0} * {1}) / 2 ", a, b, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Hexagon()
        {
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Hexagon\n-----");
            Console.WriteLine("Formula: ((3 * sqrt(3)) / 2) * side ^ 2");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Hexagon();
            }

            //output
            Console.Clear();
            ans = ((3 * Math.Sqrt(3)) / 2) * (side * side);
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Hexagon\n-----");
            Console.WriteLine("Formula: ((3 * sqrt(3)) / 2) * side ^ 2");
            Console.WriteLine("Result: ((3 * sqrt(3)) / 2) * {0} ^ 2 = {1}", side, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Circle()
        {
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Circle\n-----");
            Console.WriteLine("Formula: pi * radius ^ 2  (pi = 3.14)");
            Console.WriteLine("-----");
            Console.Write("Enter radius: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Circle();
            }

            //output
            ans = 3.14 * side * side;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Area >> Circle\n-----");
            Console.WriteLine("Formula: pi * radius ^ 2  (pi = 3.14)");
            Console.WriteLine("Result: 3.14 * {0} ^ 2 = {1}", side, ans);

            //ask
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
                    Area();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
    }
}
