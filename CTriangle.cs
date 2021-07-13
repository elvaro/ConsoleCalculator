using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class CTriangle : Geometry
    {
        protected internal static void threesides()
        {
            double ab = 0;
            double ac = 0;
            double bc = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double at = 0;
            bool loop3 = true;
            string type = "";
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle >> 3sides\n-----");
            //enter AB
            Console.WriteLine("\n" +
                "\t     A\n" +
                "\t     * \n" +
                "\t    * a * \n" +
                "\t   *       *\n" +
                "\t  *b         c*\n" +
                "\t ****************\n" +
                "\tB                C\n" +
                "-----");
            Console.Write("Enter AB: ");
            string abstr = Console.ReadLine();
            abstr = abstr.ToUpper();
            if (abstr == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(abstr, out ab) == true)
            {
                ab = double.Parse(abstr);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                threesides();
            }
            Console.Write("Enter AC: ");
            string acstr = Console.ReadLine();
            acstr = acstr.ToUpper();
            if (acstr == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(acstr, out ac) == true)
            {
                ac = double.Parse(acstr);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                threesides();
            }
            Console.Write("Enter BC: ");
            string bcstr = Console.ReadLine();
            bcstr = bcstr.ToUpper();
            if (bcstr == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(bcstr, out bc) == true)
            {
                bc = double.Parse(bcstr);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                threesides();
            }

            //calculate
            a = Math.Round((180 / Math.PI) * (Math.Acos(((ab * ab) + (ac * ac) - (bc * bc)) / (2 * ac * ab))));
            b = Math.Round((180 / Math.PI) * (Math.Acos(((ab * ab) + (bc * bc) - (ac * ac)) / (2 * ab * bc))));
            c = Math.Round((180 / Math.PI) * (Math.Acos(((ac * ac) + (bc * bc) - (ab * ab)) / (2 * ac * bc))));
            at = Math.Round(a + b + c);

            if (at != 180)
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                CheckTriangle();
            }
            else {

                if (a == 90 || b == 90 || c == 90)
                {
                    if (ab == ac || ab == bc || ac == bc)
                    {
                        type = "Right Isoceles";
                    }
                    else
                    {
                        type = "Right Scalene";
                    }
                }
                else if (a == 60 && b == 60 && c == 60)
                {
                    type = "Equilateral";
                }
                else if (ab == ac || ab == bc || ac == bc)
                {
                    type = "Isoceles";
                }
                else if (a < 90 && b < 90 && c < 90)
                {
                    type = "Acute Scalene";
                }
                else if (a > 90 || b > 90 || c > 90)
                {
                    type = "Obtuse Scalene";
                }

                //print answer
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> CheckTriangle >> 3sides\n-----");
                Console.WriteLine("\n" +
                    "\t     A\n" +
                    "\t     * \n" +
                    "\t    * a * \n" +
                    "\t   *       *\n" +
                    "\t  *b         c*\n" +
                    "\t ****************\n" +
                    "\tB                C\n" +
                    "-----");
                Console.WriteLine("This is a(n) {6} triangle\n" +
                    "Side AB = {0}\n" +
                    "Side AC = {1}\n" +
                    "Side BC = {2}\n" +
                    "Angle a = {3}\n" +
                    "Angle b = {4}\n" +
                    "Angle c = {5}\n", ab, ac, bc, a, b, c, type);

                //continue
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
                        CheckTriangle();
                    }
                    else
                    {
                        loop3 = true;
                    }
                }
            }
        }
        /*protected internal static void twosidesoneangle()
        {
            //mainmenu
            double ab = 0; double ac = 0; double bc = 0; double a = 0; double b = 0; double c = 0;
            string sab, sac, sbc, sa, sb, sc = "";
            double at = 0;
            bool loop3 = true;
            string type = "";
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle >> 2sides1angle\n-----");
            Console.WriteLine("\n" +
               "\t     A\n" +
               "\t     * \n" +
               "\t    *   * \n" +
               "\t   *       *\n" +
               "\t  *           *\n" +
               "\t ****************\n" +
               "\tB                C\n" +
               "-----");
            Console.WriteLine("How do you want to input your data?\n" +
                "1. side AB, side AC, angle a\n" +
                "2. side AB, side AC, angle b\n" +
                "3. side AB, side AC, angle c\n" +
                "4. side AB, side BC, angle a\n" +
                "5. side AB, side BC, angle b\n" +
                "6. side AB, side BC, angle c\n" +
                "7. side AC, side BC, angle a\n" +
                "8. side AC, side BC, angle b\n" +
                "9. side AC, side BC, angle c\n-----");
            Console.Write("Choose: ");
            string cmd = Console.ReadLine();
            cmd = cmd.ToUpper();
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle >> 2sides1angle\n-----");
            Console.WriteLine("\n" +
               "\t     A\n" +
               "\t     * \n" +
               "\t    *   * \n" +
               "\t   *       *\n" +
               "\t  *           *\n" +
               "\t ****************\n" +
               "\tB                C\n" +
               "-----");
            if (cmd == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            //calculation area
            else
            {
                //AB - AC - a
                if (cmd == "1")
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter a: ");
                    sa = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    bc = Math.Sqrt((ab * ab) + (ac * ac) - (2 * ab * ac * (Math.Cos(a))));
                    b = Math.Round((180 / Math.PI) * (Math.Acos(((ab * ab) + (bc * bc) - (ac * ac)) / (2 * ab * bc))));
                    c = Math.Round((180 / Math.PI) * (Math.Acos(((ac * ac) + (bc * bc) - (ab * ab)) / (2 * ac * bc))));
                }
                //AB - AC - b
                else if (cmd == "2")
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter b: ");
                    sb = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    bc = Math.Sqrt((ab * ab) + (ac * ac) - (2 * ab * ac * (Math.Cos(a))));
                    a = Math.Round((180 / Math.PI) * (Math.Acos(((ab * ab) + (ac * ac) - (bc * bc)) / (2 * ac * ab))));
                    c = Math.Round((180 / Math.PI) * (Math.Acos(((ac * ac) + (bc * bc) - (ab * ab)) / (2 * ac * bc))));
                }
                //AB - AC - c
                else if (cmd == "3")
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter c: ");
                    sc = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    bc = (ab * Math.Sin(a)) / Math.Sin(c);
                    b = Math.Round((180 / Math.PI) * (Math.Asin((ac * Math.Sin(c))/ ab)));
                    a = 180 - c - b;
                }
                //AB - BC - a
                else if (cmd == "4")
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter a: ");
                    sa = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    ac = (bc * Math.Sin(b)) / Math.Sin(a);
                    c = Math.Round((180 / Math.PI) * (Math.Asin((ab * Math.Sin(a)) / bc)));
                    b = 180 - a - c;
                }
                //AB - BC - b
                else if (cmd == "5") 
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter b: ");
                    sb = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    ac = Math.Sqrt((ab*ab) + (bc*bc) - (2*ab*bc*Math.Cos(b)));
                    c = Math.Round((180 / Math.PI) * (Math.Acos(((ac*ac) + (bc*bc) - (ab*ab)) / (2*ac*bc))));
                    a = Math.Round((180 / Math.PI) * (Math.Acos(((ac * ac) + (ab * ab) - (bc * bc)) / (2 * ac * ab))));
                }
                //AB - BC - c
                else if (cmd == "6") 
                {
                    //input
                    Console.Write("Enter AB: ");
                    sab = Console.ReadLine();
                    sab = sab.ToUpper();
                    if (sab == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sab, out ab) == true)
                    {
                        ab = double.Parse(sab);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter c: ");
                    sc = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    ac = ((ab * Math.Sin(b)) / Math.Sin(c));
                    a = Math.Round((180 / Math.PI) * (Math.Asin((bc * Math.Sin(c)) / ab)));
                    b = 180 - c - a;
                }
                //AC - BC - a
                else if (cmd == "7") 
                {
                    //input
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter a: ");
                    sa = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    b = Math.Round((180 / Math.PI) * (Math.Asin((ac * Math.Sin(a)) / bc)));
                    c = 180 - a - b;
                    ab = (bc * Math.Sin(c)) / Math.Sin(a);
                }
                //AC - BC - b
                else if (cmd == "8") 
                {
                    //input
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter b: ");
                    sb = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    a = Math.Round((180 / Math.PI) * (Math.Asin((bc * Math.Sin(b)) / ac)));
                    c = 180 - a - b;
                    ab = (ac * Math.Sin(c)) / Math.Sin(b);
                }
                //AC - BC - c
                else if (cmd == "9") 
                {
                    //input
                    Console.Write("Enter AC: ");
                    sac = Console.ReadLine();
                    sac = sac.ToUpper();
                    if (sac == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sac, out ac) == true)
                    {
                        ac = double.Parse(sac);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter BC: ");
                    sbc = Console.ReadLine();
                    sbc = sbc.ToUpper();
                    if (sbc == "DONE")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (double.TryParse(sbc, out bc) == true)
                    {
                        bc = double.Parse(sbc);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        twosidesoneangle();
                    }
                    Console.Write("Enter c: ");
                    sc = Console.ReadLine();
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
                        twosidesoneangle();
                    }

                    //calculate
                    ab = Math.Sqrt((ac * ac) + (bc * bc) - (2 * ac * bc * Math.Cos(c)));
                    a = (180 / Math.PI) * (Math.Acos(((ab * ab) + (bc * bc) - (ac * ac)) / (2 * ab * bc)));
                    b = (180 / Math.PI) * (Math.Acos(((ab * ab) + (ac * ac) - (bc * bc)) / (2 * ab * ac)));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    twosidesoneangle();

                }
            }

            //check triangle and print answer
            if (at != 180)
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Console.WriteLine("ab: {0}, ac {1}, bc {2}, a {3}, b {4}, c {5}, a+b+c {6}", ab, ac, bc, a, b, c, (a + b + c));
                CheckTriangle();
            }
            else
            {

                if (a == 90 || b == 90 || c == 90)
                {
                    if (ab == ac || ab == bc || ac == bc)
                    {
                        type = "Right Isoceles";
                    }
                    else
                    {
                        type = "Right Scalene";
                    }
                }
                else if (a == 60 && b == 60 && c == 60)
                {
                    type = "Equilateral";
                }
                else if (ab == ac || ab == bc || ac == bc)
                {
                    type = "Isoceles";
                }
                else if (a < 90 && b < 90 && c < 90)
                {
                    type = "Acute Scalene";
                }
                else if (a > 90 || b > 90 || c > 90)
                {
                    type = "Obtuse Scalene";
                }

                //print answer
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> CheckTriangle >> 2sides1angle\n-----");
                Console.WriteLine("\n" +
                    "\t     A\n" +
                    "\t     * \n" +
                    "\t    * a * \n" +
                    "\t   *       *\n" +
                    "\t  *b         c*\n" +
                    "\t ****************\n" +
                    "\tB                C\n" +
                    "-----");
                Console.WriteLine("This is a(n) {6} triangle\n" +
                    "Side AB = {0}\n" +
                    "Side AC = {1}\n" +
                    "Side BC = {2}\n" +
                    "Angle a = {3}\n" +
                    "Angle b = {4}\n" +
                    "Angle c = {5}\n", ab, ac, bc, a, b, c, type);

                //continue
                while (loop3)
                {
                    Console.WriteLine("-----");
                    Console.Write("Do you want to continue? (y/n): ");
                    string cmd1 = Console.ReadLine();
                    cmd1 = cmd1.ToUpper();
                    if (cmd1 == "N")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (cmd1 == "Y")
                    {
                        Console.Clear();
                        loop3 = false;
                        CheckTriangle();
                    }
                    else
                    {
                        loop3 = true;
                    }
                }
            }
        }
        protected internal static void onesidetwoangles()
        {
            double ab = 0; double ac = 0; double bc = 0; double a = 0; double b = 0; double c = 0;
            string sab, sac, sbc, sa, sb, sc = "";
            double at = 0;
            bool loop3 = true;
            string type = "";
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle >> 1side2angles\n-----");
            Console.WriteLine("\n" +
                   "\t     A\n" +
                   "\t     * \n" +
                   "\t    *   * \n" +
                   "\t   *       *\n" +
                   "\t  *           *\n" +
                   "\t ****************\n" +
                   "\tB                C\n" +
                   "-----");
            Console.WriteLine("How do you want to input your data?\n" +
                "1. side AB, angle a, angle b\n" +
                "2. side AB, angle a, anglc c\n" +
                "3. side AB, angle b, angle c\n" +
                "4. side AC, angle a, angle b\n" +
                "5. side AC, angle a, angle c\n" +
                "6. side AC, angle b, angle c\n" +
                "7. side BC, angle a, angle b\n" +
                "8. side BC, angle a, angle c\n" +
                "9. side BC, angle b, angle c\n-----");
            Console.Write("Choose: ");
            string cmd = Console.ReadLine();
            cmd = cmd.ToUpper();
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> CheckTriangle >> 1side2angles\n-----");
            Console.WriteLine("\n" +
               "\t     A\n" +
               "\t     * \n" +
               "\t    *   * \n" +
               "\t   *       *\n" +
               "\t  *           *\n" +
               "\t ****************\n" +
               "\tB                C\n" +
               "-----");
            if (cmd == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            //calculation area
            else
            {
                //AB - a - b
                if (cmd == "1") { }
                //AB - a - c
                else if (cmd == "2") { }
                //AB - b - c
                else if (cmd == "3") { }
                //AC - a - b
                else if (cmd == "4") { }
                //AC - a - c
                else if (cmd == "5") { }
                //AC - b - c
                else if (cmd == "6") { }
                //BC - a - b
                else if (cmd == "7") { }
                //BC - a - c
                else if (cmd == "8") { }
                //BC - b - c
                else if (cmd == "9") { }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    twosidesoneangle();
                }
            }

            //check triangle and print answer
            if (at != 180)
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                CheckTriangle();
            }
            else
            {

                if (a == 90 || b == 90 || c == 90)
                {
                    if (ab == ac || ab == bc || ac == bc)
                    {
                        type = "Right Isoceles";
                    }
                    else
                    {
                        type = "Right Scalene";
                    }
                }
                else if (a == 60 && b == 60 && c == 60)
                {
                    type = "Equilateral";
                }
                else if (ab == ac || ab == bc || ac == bc)
                {
                    type = "Isoceles";
                }
                else if (a < 90 && b < 90 && c < 90)
                {
                    type = "Acute Scalene";
                }
                else if (a > 90 || b > 90 || c > 90)
                {
                    type = "Obtuse Scalene";
                }

                //print answer
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("====================");
                Console.WriteLine("Home >> Geometry >> CheckTriangle >> 1side2angles\n-----");
                Console.WriteLine("\n" +
                    "\t     A\n" +
                    "\t     * \n" +
                    "\t    * a * \n" +
                    "\t   *       *\n" +
                    "\t  *b         c*\n" +
                    "\t ****************\n" +
                    "\tB                C\n" +
                    "-----");
                Console.WriteLine("This is a(n) {6} triangle\n" +
                    "Side AB = {0}\n" +
                    "Side AC = {1}\n" +
                    "Side BC = {2}\n" +
                    "Angle a = {3}\n" +
                    "Angle b = {4}\n" +
                    "Angle c = {5}\n", ab, ac, bc, a, b, c, type);

                //continue
                while (loop3)
                {
                    Console.WriteLine("-----");
                    Console.Write("Do you want to continue? (y/n): ");
                    string cmd1 = Console.ReadLine();
                    cmd1 = cmd1.ToUpper();
                    if (cmd1 == "N")
                    {
                        Console.Clear();
                        Program.GeometryMenu();
                    }
                    else if (cmd1 == "Y")
                    {
                        Console.Clear();
                        loop3 = false;
                        CheckTriangle();
                    }
                    else
                    {
                        loop3 = true;
                    }
                }
            }
        }*/
    }
}
